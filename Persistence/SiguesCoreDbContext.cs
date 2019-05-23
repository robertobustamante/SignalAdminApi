using Microsoft.EntityFrameworkCore;
using Model;

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
        public DbSet<Poste> Poste { get; set; }
        public DbSet<RegistroElectrico> RegistroElectrico { get; set; }
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
            modelBuilder.Entity<Modificacion>()
                .HasOne<Cableado>(m => m.Cableado)
                .WithOne(c => c.Modificacion)
                .HasForeignKey<Cableado>(c => c.ModificacionID);
        }
    }
}
