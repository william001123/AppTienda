using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable(nameof(Usuario));
            builder.HasKey(c => c.UserId);

            builder
                .HasMany<Movimiento>(oRow => oRow.Movimientos)
                .WithOne(oItem => oItem.Usuario)
                .HasForeignKey(c => c.UserId);
            builder
                .HasOne<Empleado>(oRow => oRow.Empleado)
                .WithOne(oItem => oItem.Usuario);     
        }
    }
}
