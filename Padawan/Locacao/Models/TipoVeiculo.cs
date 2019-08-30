using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class TipoVeiculo
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public decimal Valor { get; set; }
        public int Vagas { get; set; }
        public string Termo { get; set; }
    }
}