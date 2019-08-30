using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocacaoGaragem.Models
{
    public class Administrativo
    {
        [Key]
        public int Id { get; set; }
        public string TermoDeUso { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int QuantidadeDeVagas { get; set; }
        public int Valor { get; set; }
    }
}