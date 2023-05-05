using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class OrdenConfig : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable(nameof(Orden));
            builder.HasKey(c => c.IdOrden);

            builder                
                .HasMany<OrdenDetalle>(oRow => oRow.OrdenDetalles)
                .WithOne(oItem => oItem.Orden)                
                .HasForeignKey(c => c.IdOrden);
            builder
                .HasMany<Recepcion>(oRow => oRow.Recepcions)
                .WithOne(oItem => oItem.Orden)
                .HasForeignKey(c => c.IdOrden);
        }
    }
}
