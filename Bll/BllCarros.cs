using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAutoCar.Models;
using WebAutoCar.Dal;

namespace WebAutoCar.Bll
{
    public class BllCarros
    {
        public List<Carros> ListaTodos()
        {
            var dalCarros = new DalCarros();

            return dalCarros.ListaTodos();

        }

        public int Salvar(Carros carro)
        {
            var dalCarros = new DalCarros();
            if (carro.Nome == string.Empty || carro.Nome == null) 
            {
                throw new Exception("Campo nome não pode ser em branco");
            }


            return dalCarros.Salvar(carro);
        }

        public int Excluir(int id)
        {
            return new DalCarros().Excluir(id);
        }

        public int Editar(Carros carro)
        {
            return new DalCarros().Editar(carro);
        }
    }

}