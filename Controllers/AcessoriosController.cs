using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAutoCar.Models;
using WebAutoCar.Bll;

namespace WebAutoCar.Controllers
{
    public class AcessoriosController : Controller
    {
        // GET: Acessorios
        public ActionResult Index()
        {
            var listaAcessorio = new BllAcessorios();

            var result = listaAcessorio.ListaTodos();

            return View(result);
        }

        // GET: Acessorios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Acessorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acessorios/Create
        [HttpPost]
        public ActionResult Create(Acessorios acessorios)
        {
            try
            {
                // TODO: Add insert logic here

                var Acessorios = new Acessorios();
                var bllAcessorios = new BllAcessorios();

                Acessorios.Nome = acessorios.Nome;

                bllAcessorios.Salvar(Acessorios);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Acessorios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Acessorios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Acessorios acessorios)
        {
            try
            {
                var Acessorios = new Acessorios()
                {
                    IdAcessorios = id,
                    Nome = acessorios.Nome
                };

                new BllAcessorios().Editar(Acessorios);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

       

        // POST: Acessorios/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                new BllAcessorios().Excluir(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
