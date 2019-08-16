namespace WpfAppEntity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Editora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Editora()
        {
            Livros = new HashSet<Livro>();
        }

        public int Id { get; set; }

        [Column("Editora")]
        [Required]
        [StringLength(100)]
        public string Editora1 { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
