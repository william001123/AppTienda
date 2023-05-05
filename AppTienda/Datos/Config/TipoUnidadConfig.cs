using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class TipoUnidadConfig : IEntityTypeConfiguration<TipoUnidad>
    {
        public void Configure(EntityTypeBuilder<TipoUnidad> builder)
        {
            builder.ToTable(nameof(TipoUnidad));
            builder.HasKey(c => c.IdTipoUnidad);

            builder
                .HasMany<Producto>(producto => producto.Productos)
                .WithOne(oItem => oItem.TipoUnidad)
                .HasForeignKey(c => c.IdCategoria);
        }
    }
}
