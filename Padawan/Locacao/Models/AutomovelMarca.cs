﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class AutomovelMarca
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Marca { get; set; }
    }
}