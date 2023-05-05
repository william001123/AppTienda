using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class MovimientoDetalleConfig : IEntityTypeConfiguration<MovimientoDetalle>
    {

        public void Configure(EntityTypeBuilder<MovimientoDetalle> builder)
        {
            builder.ToTable(nameof(MovimientoDetalle));
            builder.HasKey(c => c.IdMovimientoDetalle);  
        }

    }
}
