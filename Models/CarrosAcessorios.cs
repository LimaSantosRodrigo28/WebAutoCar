using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAutoCar.Models
{
    public class CarrosAcessorios
    {
        [Key]
        [Display(Name = "IdCarrosAcessorios")]
        public int IdCarrosAcessorios { get; set; }

        public Carros Carro { get; set; } = new Carros();
        public Acessorios Acessorio { get; set; } = new Acessorios();
    }
}