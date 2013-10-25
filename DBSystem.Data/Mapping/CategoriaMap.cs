using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DBSystem.Core.Domain;

namespace DBSystem.Data.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.comentario)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Categoria");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.comentario).HasColumnName("comentario");
        }
    }
}
