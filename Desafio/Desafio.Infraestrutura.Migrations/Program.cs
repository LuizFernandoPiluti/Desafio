using Desafio.Infraestrutura.Dados.Contexto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Desafio.Infraestrutura.Migrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Applying migrations");
            var webHost = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<ConsoleStartup>()
                .Build();
            using (var context = (ContextoBaseDados)webHost.Services.GetService(typeof(ContextoBaseDados)))
            {
                context.Database.Migrate();
            }
            Console.WriteLine("Done");
        }
    }
}
