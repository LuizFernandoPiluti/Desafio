using Desafio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel;

namespace Desafio.Infraestrutura.Dados.Configuracao
{
    public class TipoSalaMap : IEntityTypeConfiguration<TipoSala>
    {
        public void Configure(EntityTypeBuilder<TipoSala> builder)
        {
            builder.ToTable("tipo_sala");
            builder.HasKey(m => m.IdTipoSala);
            builder.Property(m => m.IdTipoSala).HasColumnName("id_sala").ValueGeneratedOnAdd();
            builder.Property(m => m.DescricaoTipoSala).HasColumnName("descricao_tipo_sala").HasMaxLength(255);
           
            
        }
    }
}
