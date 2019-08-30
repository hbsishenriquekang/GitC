using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class MotoModelo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CodigoFK")]
        public MotoModelo Modelo { get; set; }
        public int CodigoFK { get; set; }
        public string Descricao { get; set; }
    }
}