using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class TipoOrigenConfig : IEntityTypeConfiguration<TipoOrigen>
    {
        public void Configure(EntityTypeBuilder<TipoOrigen> builder)
        {
            builder.ToTable(nameof(TipoOrigen));
            builder.HasKey(c => c.IdTipoOrigen);

            builder
                .HasMany<Movimiento>(oRow => oRow.Movimientos)
                .WithOne(oItem => oItem.TipoOrigen)
                .HasForeignKey(oItem => oItem.IdTipoOrigen);

        }
    }
}
