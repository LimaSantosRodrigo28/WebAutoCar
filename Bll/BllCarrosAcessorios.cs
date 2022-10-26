using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAutoCar.Dal;
using WebAutoCar.Models;

namespace WebAutoCar.Bll
{
    public class BllCarrosAcessorios
    {
        public IEnumerable<CarrosAcessorios> ListaTodos()
        {
            return new DalCarrosAcessorios().ListaTodos();
        }
    }
}