using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public bool PCD { get; set; } = false;
        public bool Idoso { get; set; } = false;
        public bool TrabalhoNoturno { get; set; } = false;
        public bool ResideFora { get; set; } = false;
        public bool Confirmado { get; set; } = false;
    }
}