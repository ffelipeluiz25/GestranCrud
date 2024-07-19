using CrudLuizFelipe.DataTransferObject;
namespace CrudLuizFelipe.Repositories.Interface
{
    public interface IEnderecoRepository
    {
        bool Save(EnderecoDto endereco);
    }
}
