using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudApplication.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Possui o máximo de (20) caracteres e o minimo de (3).", MinimumLength = 3)]
        public string Nome { get; set; }
        [StringLength(13, ErrorMessage = "Digite apenas números O CPF deve ter no minimo de (11) caracteres e o máximo de (13).", MinimumLength = 11)]
        public string CPF { get; set; }
        public string Logradouro { get; set; } // 256
        public int NumeroCasa { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumeroTelefone { get; set; }
        public int DDD { get; set; }
        public string TipoTelefone { get; set; }
    }
}