using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class OrdenDetalleConfig : IEntityTypeConfiguration<OrdenDetalle>
    {
        public void Configure(EntityTypeBuilder<OrdenDetalle> builder)
        {
            builder.ToTable(nameof(OrdenDetalle));
            builder.HasKey(c => c.IdOrdenDetalle);            
        }
    }
}
