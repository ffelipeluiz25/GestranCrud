using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Repositories.Interface;
using CrudLuizFelipe.Services.Interface;
namespace CrudLuizFelipe.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repoFornecedor;
        public FornecedorService(IFornecedorRepository repoFornecedor)
        {
            _repoFornecedor = repoFornecedor;
        }

        public IEnumerable<FornecedorDto> GetFornecedores()
        {
            return _repoFornecedor.GetFornecedores();
        }

        public FornecedorDto GetFornecedoresById(int id)
        {
            return _repoFornecedor.GetFornecedoresById(id);
        }

        public IEnumerable<FornecedorDto> GetFornecedoresByParams(FornecedoresFiltroDto filter)
        {
            return _repoFornecedor.GetFornecedoresByParams(filter);
        }

        public bool Save(FornecedorDto fornecedor)
        {
            return _repoFornecedor.Save(fornecedor);
        }
    }
}
