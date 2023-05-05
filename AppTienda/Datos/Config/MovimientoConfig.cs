using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class MovimientoConfig : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
            builder.ToTable(nameof(Movimiento));
            builder.HasKey(c => c.IdMovimiento);            

            //builder
            //    .HasOne<Venta>(oRow => oRow.Venta)
            //    .WithOne(oItem => oItem.Movimiento)
            //    .HasForeignKey<Venta>(c => c.IdVenta);

            //builder
            //    .HasOne<Recepcion>(oRow => oRow.Recepcion)
            //    .WithOne(oItem => oItem.Movimiento)
            //    .HasForeignKey<Recepcion>(c => c.IdRecepcion);

            builder
                .HasMany<MovimientoDetalle>(oRow => oRow.MovimientoDetalles)
                .WithOne(oItem => oItem.Movimiento)
                .HasForeignKey(c => c.IdMovimiento);            
        }
    }
}
