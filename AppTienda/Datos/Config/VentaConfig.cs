using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class VentaConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable(nameof(Venta));
            builder.HasKey(c => c.IdVenta);

            builder
                .HasMany<VentaDetalle>(oRow => oRow.VentaDetalles)
                .WithOne(oItem => oItem.Venta)
                .HasForeignKey(c => c.IdVenta);

            builder
                .HasOne<Movimiento>(oRow => oRow.Movimiento)
                .WithOne(oItem => oItem.Venta)
                .HasForeignKey<Movimiento>(c => c.IdOrigen);
        }
    }
}
