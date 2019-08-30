using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LocacaoGaragem.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Automovel> Automoveis { get; set; }
        public DbSet<AutomovelMarca> AutomovelMarcas { get; set; }
        public DbSet<AutomovelModelo> AutomovelModelos { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<MotoMarca> MotoMarcas { get; set; }
        public DbSet<MotoModelo> MotoModelos { get; set; }
        public DbSet<Bicicleta> Bicicletas { get; set; }
        public DbSet<Patinete> Patinetes { get; set; }
        public DbSet<Cor> Cores { get; set; }
    }
}