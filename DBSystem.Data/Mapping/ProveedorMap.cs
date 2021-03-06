using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DBSystem.Core.Domain;

namespace DBSystem.Data.Mapping
{
    public class ProveedorMap : EntityTypeConfiguration<Proveedor>
    {
        public ProveedorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.razonSocial)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ruc)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.direccion)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Proveedor");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.razonSocial).HasColumnName("razonSocial");
            this.Property(t => t.ruc).HasColumnName("ruc");
            this.Property(t => t.direccion).HasColumnName("direccion");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
