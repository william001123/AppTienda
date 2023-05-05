using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.Config
{
    public class EmpleadoConfig : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable(nameof(Empleado));
            builder.HasKey(c => c.IdEmpleado);

            builder
                .HasOne<Usuario>(oRow => oRow.Usuario)
                .WithOne(oItem => oItem.Empleado)
                .HasForeignKey<Usuario>(c => c.IdEmpleado);
        }
    }
}
