using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocacaoGaragem.Models
{
    public class MotoMarca
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Marca { get; set; }

    }
}