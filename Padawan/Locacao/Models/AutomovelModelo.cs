using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class AutomovelModelo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CodigoFK")]
        public AutomovelMarca Marca { get; set; }
        public int CodigoFK { get; set; }
        public string Descricao { get; set; }
    }
}