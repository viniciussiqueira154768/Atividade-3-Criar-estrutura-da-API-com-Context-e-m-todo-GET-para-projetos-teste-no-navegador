using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Exo.WebApi.Contexts
{
public class ExoContext : DbContext
{
        private object sa;
        private object admin;
        private object localhost;

        public ExoContext()
{
}
public ExoContext(DbContextOptions<ExoContext> options) :
base(options)
{
}
protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
{
if(!optionsBuilder.IsConfigured)
{
// Essa string de conexão depende da SUA máquina.
optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"
+ "Database=ExoApi;Trusted_Connection=True;");
// Exemplo 1 de string de conexão:
// User
ID=sa;
Password=admin;
Server=localhost;
Database=ExoApi;
// + Trusted_Connection=False;


}
}
public DbSet<Projeto> Projetos { get; set; }
        public DatabaseFacade ExoApi { get; private set; }
        public object ID { get; private set; }
        public object Password { get; private set; }

        private object Server;
        private object Database;
    }
}