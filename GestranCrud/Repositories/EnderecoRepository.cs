using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Repositories.Interface;
namespace CrudLuizFelipe.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public EnderecoRepository() { }
        public IEnumerable<EnderecoDto> GetEnderecoes()
        {
            throw new NotImplementedException();
        }

        public EnderecoDto GetEnderecoesById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(EnderecoDto Endereco)
        {
            throw new NotImplementedException();
        }
    }
}
