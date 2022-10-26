using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAutoCar.Models
{
    public class Acessorios
    {
        [Key]
		[Display(Name = "IdAcessorios")]
        public int IdAcessorios { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}