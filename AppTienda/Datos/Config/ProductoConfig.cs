using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable(nameof(Producto));
            builder.HasKey(c => c.IdProducto);

            builder
                .HasMany<VentaDetalle>(oRow => oRow.VentaDetalles)
                .WithOne(oItem => oItem.Producto)
                .HasForeignKey(c => c.IdProducto);

            builder
                .HasMany<OrdenDetalle>(oRow => oRow.OrdenDetalles)
                .WithOne(oItem => oItem.Producto)
                .HasForeignKey(c => c.IdProducto);

            builder
                .HasMany<RecepcionDetalle>(oRow => oRow.RecepcionDetalles)
                .WithOne(oItem => oItem.Producto)
                .HasForeignKey(c => c.IdProducto);

            builder
                .HasMany<MovimientoDetalle>(oRow => oRow.MovimientoDetalles)
                .WithOne(oItem => oItem.Producto)
                .HasForeignKey(c => c.IdProducto);
        }
    }
}
