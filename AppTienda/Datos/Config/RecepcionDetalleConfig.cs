using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class RecepcionDetalleConfig : IEntityTypeConfiguration<RecepcionDetalle>
    {
        public void Configure(EntityTypeBuilder<RecepcionDetalle> builder)
        {
            builder.ToTable(nameof(RecepcionDetalle));
            builder.HasKey(c => c.IdRecepcionDetalle);
        }
    }
}
