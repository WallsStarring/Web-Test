using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_Test.Models.Pachacamac
{
    public partial class PachacamacContext : DbContext
    {
        public PachacamacContext()
        {
        }

        public PachacamacContext(DbContextOptions<PachacamacContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetPeds> DetPeds { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Transportes> Transportes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Pachacamac;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.Property(e => e.ArchivoImagen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip).HasColumnType("ntext");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.CargoCont).HasMaxLength(30);

                entity.Property(e => e.Ciudad).HasMaxLength(15);

                entity.Property(e => e.Codigo).HasMaxLength(5);

                entity.Property(e => e.Contacto).HasMaxLength(30);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPostal")
                    .HasMaxLength(10);

                entity.Property(e => e.Dire).HasMaxLength(60);

                entity.Property(e => e.Fax).HasMaxLength(24);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.Te)
                    .HasColumnName("TE")
                    .HasMaxLength(24);

                entity.HasOne(d => d.IdPaisesNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdPaises)
                    .HasConstraintName("FK_Clientes_Paises");
            });

            modelBuilder.Entity<DetPeds>(entity =>
            {
                entity.Property(e => e.PrecioUnidad).HasColumnType("money");

                entity.HasOne(d => d.IdPedidosNavigation)
                    .WithMany(p => p.DetPeds)
                    .HasForeignKey(d => d.IdPedidos)
                    .HasConstraintName("FK_DetPeds_Pedidos");

                entity.HasOne(d => d.IdProductosNavigation)
                    .WithMany(p => p.DetPeds)
                    .HasForeignKey(d => d.IdProductos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetPeds_Productos");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Cargo).HasMaxLength(30);

                entity.Property(e => e.Ciudad).HasMaxLength(15);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPostal")
                    .HasMaxLength(10);

                entity.Property(e => e.Dire).HasMaxLength(60);

                entity.Property(e => e.Exten).HasMaxLength(4);

                entity.Property(e => e.FechaContrat).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaNac).HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Notas).HasColumnType("ntext");

                entity.Property(e => e.Pais).HasMaxLength(15);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.TelDomicilio).HasMaxLength(24);

                entity.Property(e => e.Tratamiento).HasMaxLength(25);
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.Property(e => e.CodEnTransportes)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Pais).HasMaxLength(15);
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.Property(e => e.Cargo).HasColumnType("money");

                entity.Property(e => e.CiudadDest).HasMaxLength(15);

                entity.Property(e => e.CpostalDes)
                    .HasColumnName("CPostalDes")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinatario).HasMaxLength(40);

                entity.Property(e => e.DirDestinatario).HasMaxLength(60);

                entity.Property(e => e.FechaEntr).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEnv).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaPed).HasColumnType("smalldatetime");

                entity.Property(e => e.RegDestinatario).HasMaxLength(15);

                entity.HasOne(d => d.IdClientesNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdClientes)
                    .HasConstraintName("FK_Pedidos_Clientes");

                entity.HasOne(d => d.IdEmpleadosNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEmpleados)
                    .HasConstraintName("FK_Pedidos_Empleados");

                entity.HasOne(d => d.IdPaisesNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdPaises)
                    .HasConstraintName("FK_Pedidos_Paises");

                entity.HasOne(d => d.IdTransportesNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdTransportes)
                    .HasConstraintName("FK_Pedidos_Transportes");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.CantidadPorUnidad).HasMaxLength(20);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.PrecioUnidad).HasColumnType("money");

                entity.HasOne(d => d.IdCategoríasNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategorías)
                    .HasConstraintName("FK_Productos_Categorías");

                entity.HasOne(d => d.IdProveedoresNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProveedores)
                    .HasConstraintName("FK_Productos_Proveedores");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.Property(e => e.CargoContacto).HasMaxLength(30);

                entity.Property(e => e.Ciudad).HasMaxLength(15);

                entity.Property(e => e.Contacto).HasMaxLength(30);

                entity.Property(e => e.Cpostal)
                    .HasColumnName("CPostal")
                    .HasMaxLength(10);

                entity.Property(e => e.Direc).HasMaxLength(60);

                entity.Property(e => e.Fax).HasMaxLength(24);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.PagPrincipal).HasColumnType("ntext");

                entity.Property(e => e.Pais).HasMaxLength(15);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.Te)
                    .HasColumnName("TE")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<Transportes>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Te)
                    .HasColumnName("TE")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("PK_Usuario");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreyApellidos)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
