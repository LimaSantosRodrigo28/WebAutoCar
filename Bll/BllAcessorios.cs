using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAutoCar.Dal;
using WebAutoCar.Models;

namespace WebAutoCar.Bll
{
    public class BllAcessorios
    {
        public List<Acessorios> ListaTodos()
        {
            var dalAcessorios = new DalAcessorios();

            return dalAcessorios.ListaTodos();

        }
        public int Salvar(Acessorios acessorios)
        {
            var dalAcessorios = new DalAcessorios();
            if (acessorios.Nome == string.Empty || acessorios.Nome == null)
            {
                throw new Exception("Campo nome não pode ser em branco");
            }

            return dalAcessorios.Salvar(acessorios);
        }
        public int Excluir(int id)
        {
            return new DalAcessorios().Excluir(id);
        }

        
        public int Editar(Acessorios acessorios)
        {
            return new DalAcessorios().Editar(acessorios);
        }
    }
}