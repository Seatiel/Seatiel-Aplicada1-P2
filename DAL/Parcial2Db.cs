using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace DAL
{
    public class Parcial2Db : DbContext 
    {
        public Parcial2Db() : base ("name=ConStr")
        {

        }

        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<TiposTelefonos> TipoTelefono { get; set; }
        public DbSet<ClientesTelefonos> ClienteTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                .HasMany<Clientes>(t => t.Cliente)
                .WithMany(c => c.TipoTelefono)
                .Map(Tc =>
                {
                    Tc.MapLeftKey("TipoId");
                    Tc.MapRightKey("ClienteId");
                    Tc.ToTable("ClientesTelefonos");
                });
        }
    }
}
