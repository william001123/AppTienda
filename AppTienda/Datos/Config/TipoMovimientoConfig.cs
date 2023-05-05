using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class TipoMovimientoConfig : IEntityTypeConfiguration<TipoMovimiento>
    {
        public void Configure(EntityTypeBuilder<TipoMovimiento> builder)
        {
            builder.ToTable(nameof(TipoMovimiento));
            builder.HasKey(c => c.IdTipoMovimiento);

            builder
                .HasMany<Movimiento>(oRow => oRow.Movimientos)
                .WithOne(oItem => oItem.TipoMovimiento)
                .HasForeignKey(oItem => oItem.IdTipoMovimiento);
        }
    }
}
