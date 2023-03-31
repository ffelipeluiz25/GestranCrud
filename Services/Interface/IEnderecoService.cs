using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Services.Interface
{
    public interface IEnderecoService
    {
        public IEnumerable<EnderecoDto> GetEnderecos();
        public EnderecoDto GetEnderecosById(int id);
        public bool Save(EnderecoDto endereco);
    }
}