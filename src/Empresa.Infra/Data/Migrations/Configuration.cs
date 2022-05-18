using System.Data.Entity.Migrations;

namespace Empresa.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.EmpresaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
