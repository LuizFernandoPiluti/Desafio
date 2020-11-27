using Desafio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Infraestrutura.Dados.Configuracao
{
    public class SalaMap : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("sala");
            builder.HasKey(m => m.IdSala);
            builder.Property(m => m.IdSala).HasColumnName("id_sala").ValueGeneratedOnAdd();
            builder.Property(m => m.CodigoSala).HasColumnName("codigo_sala").HasMaxLength(50);
            builder.Property(m => m.NomeSala).HasColumnName("nome_sala").HasMaxLength(255);
            builder.HasOne(m => m.TipoSala).WithMany().HasForeignKey(m => m.IdTipoSala);
            builder.HasOne(m => m.TamanhoSala).WithMany().HasForeignKey(m => m.IdTamanhoSala);


        }
    }
}
