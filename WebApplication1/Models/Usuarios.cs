using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuario : UserControls
    {
        [Key]
        
        public int Id { get; set; }
        [CustomValidFields(Enum.ValidFields.ValidaNome)]
        public string Nome { get; set; }
        [CustomValidFields(Enum.ValidFields.ValidaNome)]
        public string Email { get; set; }
        
        [CustomValidFields(Enum.ValidFields.ValidaLogin)]
        public string Login { get; set; }
        [CustomValidFields(Enum.ValidFields.ValidaSenha)]
        public string Senha { get; set; }
    }
}