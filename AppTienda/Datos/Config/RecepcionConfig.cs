using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class RecepcionConfig : IEntityTypeConfiguration<Recepcion>
    {
        public void Configure(EntityTypeBuilder<Recepcion> builder)
        {
            builder.ToTable(nameof(Recepcion));
            builder.HasKey(c => c.IdRecepcion);

            builder
                .HasOne<Movimiento>(oRow => oRow.Movimiento)
                .WithOne(oItem => oItem.Recepcion)
                .HasForeignKey<Movimiento>(c => c.IdOrigen);
            builder
                .HasMany<RecepcionDetalle>(oRow => oRow.RecepcionDetalles)
                .WithOne(oItem => oItem.Recepcion)
                .HasForeignKey(c => c.IdRecepcion);
        }
    }
}
