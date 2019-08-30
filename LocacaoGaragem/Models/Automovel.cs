using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LocacaoGaragem.Models
{
    public class Automovel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MarcaFK")]
        public MotoMarca Marca { get; set; }
        public int MarcaFK { get; set; }
        [ForeignKey("ModeloFK")]
        public MotoModelo Modelo { get; set; }
        public int ModeloFK { get; set; }

        [ForeignKey("CorFK")]
        public Cor Cor { get; set; }
        public int CorFK { get; set; }
        public string Placa { get; set; }
        public bool DescontoEmFolha { get; set; } = false;
        public bool Ativo { get; set; } = false;
        

    }
}