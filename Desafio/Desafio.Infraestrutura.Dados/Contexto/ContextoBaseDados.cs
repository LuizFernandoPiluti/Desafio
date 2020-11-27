using Desafio.Infraestrutura.Dados.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Desafio.Infraestrutura.Dados.Contexto
{
    public class ContextoBaseDados: DbContext
    {
        public ContextoBaseDados(DbContextOptions<ContextoBaseDados> opcoes) : base(opcoes)
        {
        }

        public ContextoBaseDados()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SalaMap());
            modelBuilder.ApplyConfiguration(new TipoSalaMap());
            modelBuilder.ApplyConfiguration(new TamanhoSalaMap());
       


            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            ;

           optionsBuider.UseSqlServer(config.GetConnectionString("CentralSistemas"));

        }

    }
}
