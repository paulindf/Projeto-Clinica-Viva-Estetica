using AutoMapper;
using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaEstetica.MVC.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaAppService servicoAgenda;
        private readonly IClienteAppService servicoCliente;

        public AgendaController(IAgendaAppService servicoAgenda, IClienteAppService servicoCliente)
        {
            this.servicoAgenda = servicoAgenda;
            this.servicoCliente = servicoCliente;
        }

        public ActionResult Index() => View(Mapper.Map<IEnumerable<Agenda>, IEnumerable<AgendaViewModel>>(servicoAgenda.SelecionarTodos()));

        public ActionResult Details(int id) => View(RetornarAgendaVM(id));

        private AgendaViewModel RetornarAgendaVM(int id) => Mapper.Map<Agenda, AgendaViewModel>(servicoAgenda.SelecionarPorId(id));

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgendaViewModel agenda)
        {
            if (ModelState.IsValid)
            {
                agenda.Cliente = Mapper.Map<Cliente, ClienteViewModel>(servicoCliente.SelecionarPorId(1));

                servicoAgenda.Adicionar(Mapper.Map<AgendaViewModel, Agenda>(agenda));
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id) => View(RetornarAgendaVM(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AgendaViewModel agenda)
        {
            if (ModelState.IsValid)
            {
                servicoAgenda.Atualizar(Mapper.Map<AgendaViewModel, Agenda>(agenda));

                return RedirectToAction("Index");
            }

            return View(agenda);
        }

        public ActionResult Delete(int id)
        {
            servicoAgenda.Remover(servicoAgenda.SelecionarPorId(id));
            return RedirectToAction("Index");
        }
    }
}
