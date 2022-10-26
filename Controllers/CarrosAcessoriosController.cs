using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAutoCar.Bll;
using WebAutoCar.Models;

namespace WebAutoCar.Controllers
{
    public class CarrosAcessoriosController : Controller
    {
        // GET: CarrosAcessorios
        public ActionResult Index()
        {
            var result = new BllCarrosAcessorios().ListaTodos();

            return View(result);
        }

    }
}
