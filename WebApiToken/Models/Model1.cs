using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApiToken.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelBD")
        {
        }

        public virtual DbSet<datos_Identificativos_Usuario> datos_Identificativos_Usuario { get; set; }
        public virtual DbSet<datos_Sesion_Usuario> datos_Sesion_Usuario { get; set; }
        public virtual DbSet<datos_Tarjeta_Usuario> datos_Tarjeta_Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.nombre_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.app_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.apm_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.curp_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.rfc_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.estadoCivil_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.sexo_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.religion_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.lugarNacimiento_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .Property(e => e.viveEn_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .HasOptional(e => e.datos_Sesion_Usuario)
                .WithRequired(e => e.datos_Identificativos_Usuario);

            modelBuilder.Entity<datos_Identificativos_Usuario>()
                .HasOptional(e => e.datos_Tarjeta_Usuario)
                .WithRequired(e => e.datos_Identificativos_Usuario);

            modelBuilder.Entity<datos_Sesion_Usuario>()
                .Property(e => e.nickName_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Sesion_Usuario>()
                .Property(e => e.email_usario)
                .IsUnicode(false);

            modelBuilder.Entity<datos_Sesion_Usuario>()
                .Property(e => e.password_usuario)
                .IsUnicode(false);
        }
    }
}
