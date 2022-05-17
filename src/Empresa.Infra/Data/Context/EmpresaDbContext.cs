using Empresa.Business.Models.Fornecedores;
using Empresa.Business.Models.Produtos;
using System.Data.Entity;

namespace Empresa.Infra.Data.Context
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext() : base("DefaultConnection")
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
