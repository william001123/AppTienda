using Datos.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Config
{
    public class ProveedorConfig : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable(nameof(Proveedor));
            builder.HasKey(c => c.IdProveedor);

            builder
                .HasMany<Orden>(oRow => oRow.Ordens)
                .WithOne(oItem => oItem.Proveedor)
                .HasForeignKey(c => c.IdProveedor);
        }
    }
}
