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
            builder.Property(m => m.TamanhoSala).HasColumnName("tamanho_sala").HasMaxLength(50); ;
            builder.Property(m => m.TipoSala).HasColumnName("tipo_sala").HasMaxLength(100); ;
            builder.Property(m => m.OrdemMatriz).HasColumnName("ordem_matriz");

         


        }
    }
}
