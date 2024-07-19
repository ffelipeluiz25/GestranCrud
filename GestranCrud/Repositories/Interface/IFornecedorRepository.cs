using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Repositories.Interface
{
    public interface IFornecedorRepository
    {
        public IEnumerable<FornecedorDto> GetFornecedores();
        public FornecedorDto GetFornecedoresById(int id);
        IEnumerable<FornecedorDto> GetFornecedoresByParams(FornecedoresFiltroDto filter);
        public bool Save(FornecedorDto fornecedor);
    }
}
