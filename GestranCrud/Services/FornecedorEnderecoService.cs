using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Repositories.Interface;
using CrudLuizFelipe.Services.Interface;
namespace CrudLuizFelipe.Services
{
    public class FornecedorEnderecoService : IFornecedorEnderecoService
    {
        private readonly IFornecedorEnderecoRepository _repoFornecedorEndereco;
        public FornecedorEnderecoService(IFornecedorEnderecoRepository repoFornecedorEndereco)
        {
            _repoFornecedorEndereco = repoFornecedorEndereco;
        }

        #region Metodos

        public IEnumerable<FornecedorEnderecoDto> GetEnderecosDoFornecedor(int EnderecoId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FornecedorEnderecoDto> GetFornecedoresByEnderecoId(int FornecedorId)
        {
            throw new NotImplementedException();
        }

        public bool Save(FornecedorEnderecoDto fornecedorEndereco)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
