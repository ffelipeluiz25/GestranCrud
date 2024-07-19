using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Repositories.Interface;
using CrudLuizFelipe.Services.Interface;
namespace CrudLuizFelipe.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repoEndereco;
        public EnderecoService(IEnderecoRepository repoEndereco)
        {
            _repoEndereco = repoEndereco;
        }

        #region Metodos

        public IEnumerable<EnderecoDto> GetEnderecos()
        {
            throw new NotImplementedException();
        }

        public EnderecoDto GetEnderecosById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(EnderecoDto Endereco)
        {
            return _repoEndereco.Save(Endereco);
        }

        #endregion

    }
}
