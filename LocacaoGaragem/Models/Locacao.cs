using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocacaoGaragem.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        public int Tipo { get; set; }

    }
}