namespace WpfAppEntity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biblioteca")]
    public partial class Biblioteca
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Senha { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }
    }
}
