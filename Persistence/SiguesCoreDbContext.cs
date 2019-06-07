using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Persistence
{
    public class SiguesCoreDbContext : DbContext
    {
        //Entidades
        public DbSet<Activo> Activo { get; set; }
        public DbSet<ActivoInterseccionControl> ActivoInterseccionControl { get; set; }
        public DbSet<ActivoInterseccionInstalacion> ActivoInterseccionInstalacion { get; set; }
        public DbSet<ActivoSensor> ActivoSensor { get; set; }
        public DbSet<ActivoSVAE> ActivoSVAE { get; set; }
        public DbSet<ActivoSV> ActivoSV { get; set; }
        public DbSet<Cableado> Cableado { get; set; }
        public DbSet<Control> Control { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Modificacion> Modificacion { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Poste> Poste { get; set; }
        public DbSet<RegistroElectrico> RegistroElectrico { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Semaforo> Semaforo { get; set; }
        public DbSet<TipoActivo> TipoActivo { get; set; }
        public DbSet<TipoControl> TipoControl { get; set; }
        public DbSet<TipoPoste> TipoPoste { get; set; }
        public DbSet<TipoSemaforo> TipoSemaforo { get; set; }
        public DbSet<TipoSenalamiento> TipoSenalamiento { get; set; }
        public DbSet<TipoSensor> TipoSensor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioSec> UsuarioSec { get; set; }


        public SiguesCoreDbContext(DbContextOptions<SiguesCoreDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Foreign Keys Modificacion
            modelBuilder.Entity<Modificacion>()
                .HasOne<Activo>(m => m.Activo)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Activo>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<ActivoInterseccionControl>(m => m.ActivoInterseccionControl)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<ActivoInterseccionControl>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<ActivoInterseccionInstalacion>(m => m.ActivoInterseccionInstalacion)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<ActivoInterseccionInstalacion>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<ActivoSensor>(m => m.ActivoSensor)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<ActivoSensor>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<ActivoSV>(m => m.ActivoSV)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<ActivoSV>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<ActivoSVAE>(m => m.ActivoSVAE)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<ActivoSVAE>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Cableado>(m => m.Cableado)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Cableado>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Control>(m => m.Control)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Control>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Material>(m => m.Material)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Material>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Permiso>(m => m.Permiso)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Permiso>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Poste>(m => m.Poste)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Poste>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<RegistroElectrico>(m => m.RegistroElectrico)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<RegistroElectrico>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Rol>(m => m.Rol)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Rol>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Semaforo>(m => m.Semaforo)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Semaforo>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoActivo>(m => m.TipoActivo)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoActivo>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoControl>(m => m.TipoControl)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoControl>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoPoste>(m => m.TipoPoste)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoPoste>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoSemaforo>(m => m.TipoSemaforo)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoSemaforo>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoSenalamiento>(m => m.TipoSenalamiento)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoSenalamiento>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<TipoSensor>(m => m.TipoSensor)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<TipoSensor>(c => c.ModificacionID);

            modelBuilder.Entity<Modificacion>()
                .HasOne<Usuario>(m => m.Usuario)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Usuario>(c => c.ModificacionID);
            #endregion
            #region Foreign Keys Usuarios
            modelBuilder.Entity<UsuarioSec>()
                .HasOne<Usuario>(m => m.Usuario)
                .WithOne(c => c.UsuarioSec)
                .HasForeignKey<Usuario>(c => c.UsuarioID);           

            modelBuilder.Entity<Rol>()
                .HasOne<Usuario>(m => m.Usuario)
                .WithOne(c => c.Rol)
                .HasForeignKey<Usuario>(c => c.RolID);

            modelBuilder.Entity<Permiso>()
                .HasOne<Rol>(m => m.Rol)
                .WithOne(c => c.Permiso)
                .HasForeignKey<Rol>(c => c.RolID);
            #endregion
            #region Foreign Key Activos

            #endregion
            #region Seed Info
            Login login = new Login();

            modelBuilder.Entity<Modificacion>()
                .HasData(new Modificacion
                {
                    ModificacionID = 1,
                    CreadoPor = 1,
                    FechaCreacion = DateTime.UtcNow,
                    Eliminado = false
                });

            modelBuilder.Entity<Rol>()
                .HasData(new Rol
                {
                    RolID = 1,
                    Descripcion = "Administracion",
                    ModificacionID = 1
                });

            modelBuilder.Entity<Modificacion>()
                .HasData(new Modificacion
                {
                    ModificacionID = 2,
                    CreadoPor = 1,
                    FechaCreacion = DateTime.UtcNow,
                    Eliminado = false
                });

            modelBuilder.Entity<Permiso>()
                .HasData(new Permiso
                {
                    PermisoID = 1,
                    RolID = 1,
                    Descripcion = "<Controller>Usuario",
                    View = true,
                    Create = true,
                    Read = true,
                    Update = true,
                    Delete = true,
                    ModificacionID = 2
                });

            modelBuilder.Entity<Modificacion>()
                .HasData(new Modificacion
                {
                    ModificacionID = 3,
                    CreadoPor = 1,
                    FechaCreacion = DateTime.UtcNow,
                    Eliminado = false
                });

            modelBuilder.Entity<Usuario>()
                .HasData(new Usuario
                {
                    UsuarioID = 1,
                    NombreUsuario = "Administrador",
                    Email = "admin@sigues.com",
                    RolID = 1,
                    ModificacionID = 3
                });            

            modelBuilder.Entity<UsuarioSec>()
                .HasData(new UsuarioSec
                {
                    UsuariosecID = 1,
                    UsuarioID = 1,
                    Psw = login.HashPsw("Aprobado123"),
                    PreguntaPsw = "",
                    RespuestaPsw = "",
                    IntentosFallidosLogin = 0,
                    BloqueoLogin = false,
                    IntentosFallidosPregunta = 0,
                    BloqueoPregunta = false
                });
            #endregion
        }
    }
}
