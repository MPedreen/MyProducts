using System;
using System.Threading.Tasks;
using Empresa.Business.Models.Fornecedores;
using Empresa.Infra.Data.Repository;

namespace Empresas.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}