using Desafio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Infraestrutura.Dados.Configuracao
{
    public class TamanhoSalaMap : IEntityTypeConfiguration<TamanhoSala>
    {
        public void Configure(EntityTypeBuilder<TamanhoSala> builder)
        {
            builder.ToTable("tamanho_sala");
            builder.HasKey(m => m.IdTamanhoSala);
            builder.Property(m => m.IdTamanhoSala).HasColumnName("id_tamanho_sala").ValueGeneratedOnAdd();
            builder.Property(m => m.DescricaoTamanhoSala).HasColumnName("descricao_tamanho_sala").HasMaxLength(255);
        }
    }
}
