using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Services.Interface
{
    public interface IFornecedorEnderecoService
    {
        IEnumerable<FornecedorEnderecoDto> GetEnderecosDoFornecedor(int EnderecoId);
        IEnumerable<FornecedorEnderecoDto> GetFornecedoresByEnderecoId(int FornecedorId);
        public bool Save(FornecedorEnderecoDto fornecedorEndereco);
    }
}