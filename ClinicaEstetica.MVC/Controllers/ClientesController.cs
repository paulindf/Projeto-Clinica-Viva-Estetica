using AutoMapper;
using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClinicaEstetica.MVC.Controllers
{
    public class ClientesController : Controller
    {
        //private UnitOfWork uow = new UnitOfWork();

        private readonly IClienteAppService clienteapp;

        public ClientesController(IClienteAppService clienteapp) => this.clienteapp = clienteapp;
        
        public ActionResult Index() => View(Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clienteapp.SelecionarTodos()));

        private ClienteViewModel RetornaClienteById(int id) => Mapper.Map<Cliente, ClienteViewModel>(clienteapp.SelecionarPorId(id));

        public ActionResult Details(int id) => View(RetornaClienteById(id));
        
        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                clienteapp.Adicionar(Mapper.Map<ClienteViewModel, Cliente>(cliente));
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Edit(int id) => View(RetornaClienteById(id));
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                clienteapp.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(cliente));

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            clienteapp.Remover(clienteapp.SelecionarPorId(id));
            return RedirectToAction("Index");
        }
    }
}
