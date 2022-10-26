using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAutoCar.Models
{
    public class Carros
    {
		[Key]
		[Display(Name = "IdCarro")]
		public int IdCarro { get; set; }

		[Display(Name = "Nome")]
		public string Nome { get; set; }

		public List<Acessorios> ListaAcessorios = new List<Acessorios>();
	}
}