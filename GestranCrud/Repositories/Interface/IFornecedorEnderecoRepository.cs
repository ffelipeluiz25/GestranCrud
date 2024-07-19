using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Repositories.Interface
{
    public interface IFornecedorEnderecoRepository
    {
        IEnumerable<FornecedorEnderecoDto> GetEnderecosDoFornecedor(int EnderecoId);
        IEnumerable<FornecedorEnderecoDto> GetFornecedoresByEnderecoId(int FornecedorId);
        public bool Save(FornecedorEnderecoDto fornecedorEndereco);
    }
}
