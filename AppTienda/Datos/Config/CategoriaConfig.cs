using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    internal class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable(nameof(Categoria));
            builder.HasKey(c => c.IdCategoria);

            builder
                .HasMany<Producto>(producto => producto.Productos)
                .WithOne(oItem => oItem.Categoria)
                .HasForeignKey(c => c.IdCategoria);
        }
    }
}
