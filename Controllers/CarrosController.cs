using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAutoCar.Models;
using WebAutoCar.Bll;

namespace WebAutoCar.Controllers
{
    public class CarrosController : Controller
    {
        // GET: Carros
        public ActionResult Index()
        {
            var listaCarros = new BllCarros();

            var result = listaCarros.ListaTodos();

            return View(result);

        }

        // GET: Carros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Carros/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Carros/Create
        [HttpPost]
        public ActionResult Create(Carros carro)
        {
            try
            {
                // TODO: Add insert logic here
                
                var Carro = new Carros();
                var bllCarro = new BllCarros();

                Carro.Nome = carro.Nome;

                bllCarro.Salvar(Carro);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Carros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Carros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Carros carro)
        {
            try
            {
                var Carro = new Carros()
                {
                    IdCarro = id,
                    Nome = carro.Nome
                };

                new BllCarros().Editar(Carro);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // POST: Carros/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                new BllCarros().Excluir(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
