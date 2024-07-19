using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Services.Interface
{
    public interface IFornecedorService
    {
        public IEnumerable<FornecedorDto> GetFornecedores();
        public FornecedorDto GetFornecedoresById(int id);
        IEnumerable<FornecedorDto> GetFornecedoresByParams(FornecedoresFiltroDto filter);
        public bool Save(FornecedorDto fornecedor);
    }
}
