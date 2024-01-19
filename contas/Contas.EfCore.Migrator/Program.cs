using Contas.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

await Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
      string connectionString = "Server=127.0.0.1;Port=5432;Database=contas;User Id=postgres;Password=Postgres2022!;CommandTimeout=20;";
      services.AddDbContext<ContasDbContext>(options => {
        options.UseNpgsql(connectionString, b => b.MigrationsAssembly("Contas.EfCore.Migrator"));
      });
    })
    .Build()
    .RunAsync();

//HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);