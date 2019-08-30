using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Locacao.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<AutomovelMarca> AutomovelMarcas { get; set; }
        public DbSet<AutomovelModelo> AutomovelModelos { get; set; }
        public DbSet<MotoMarca> MotoMarcas { get; set; }
        public DbSet<MotoModelo> MotoModelos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculos { get; set; }
    }
}