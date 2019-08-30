using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UsuarioFK")]
        public virtual Usuario Usuario { get; set; }
        public int UsuarioFK { get; set; }
        [CustomPlacaValidator(Enums.ValidFields.ValidaTipo)]
        [ForeignKey("TipoFK")]
        public virtual TipoVeiculo Tipo { get; set; }
        public int TipoFK { get; set; }

        [ForeignKey("MarcaFK")]
        public virtual AutomovelMarca Marca { get; set; }
        public int MarcaFK { get; set; }
        public int Modelo { get; set; }

        [ForeignKey("CorFK")]
        public virtual Cor Cor { get; set; }
        public int CorFK { get; set; }
        [CustomPlacaValidator(Enums.ValidFields.ValidaPlaca)]
        public string Placa { get; set; }

        //Era pra ser uma FK mas eu nao sei como fazer
        
        public DateTime InicioFK { get; set; }

        //Era pra ser uma FK mas eu nao sei como fazer

        public DateTime FinalFK { get; set; }
        public bool TermosDeUso { get; set; } = true;
        public bool DescontoEmFolha { get; set; } = true;
        public string Status { get; set; } = "Em Aprovação";
    }
}