using Empresa.Business.Core.Data;
using Empresa.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Empresa.Business.Models.Fornecedores
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
