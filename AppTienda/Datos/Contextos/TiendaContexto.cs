using Datos.Config;
using Datos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AppFinanciero.Infraestructura.Datos.Contextos
{
    public class TiendaContexto: DbContext
    {
        //Se agregan los modelos del dominio

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<MovimientoDetalle> MovimientoDetalle { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Recepcion> Recepcion { get; set; }
        public DbSet<RecepcionDetalle> RecepcionDetalle { get; set; }
        public DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public DbSet<TipoOrigen> TipoOrigen { get; set; }
        public DbSet<TipoUnidad> TipoUnidad { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<VentaDetalle> VentaDetalle { get; set; }

        public TiendaContexto()
        {
        }

        public TiendaContexto(DbContextOptions<TiendaContexto> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
            //IConfigurationRoot root = builder.Build();

            //optionsBuilder.UseSqlServer(root["ConnectionStrings:Financiero"]);

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6GEM4G9;Initial Catalog=dbTienda;Integrated Security=true;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoriaConfig());
            modelBuilder.ApplyConfiguration(new EmpleadoConfig());
            modelBuilder.ApplyConfiguration(new MovimientoConfig());
            modelBuilder.ApplyConfiguration(new MovimientoDetalleConfig());
            modelBuilder.ApplyConfiguration(new OrdenConfig());
            modelBuilder.ApplyConfiguration(new OrdenDetalleConfig());
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new ProveedorConfig());
            modelBuilder.ApplyConfiguration(new RecepcionConfig());
            modelBuilder.ApplyConfiguration(new RecepcionDetalleConfig());
            modelBuilder.ApplyConfiguration(new TipoMovimientoConfig());
            modelBuilder.ApplyConfiguration(new TipoOrigenConfig());
            modelBuilder.ApplyConfiguration(new TipoUnidadConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new VentaConfig());
            modelBuilder.ApplyConfiguration(new VentaDetalleConfig());            
        }
    }
}
