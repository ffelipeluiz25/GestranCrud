using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Enumeradores;
using CrudLuizFelipe.Repositories.Interface;
namespace CrudLuizFelipe.Repositories
{
    public class FornecedorEnderecoRepository : IFornecedorEnderecoRepository
    {
        private readonly IMemoryRepository _memoryRepoCache;
        public FornecedorEnderecoRepository(IMemoryRepository memoryRepoCache)
        {
            _memoryRepoCache = memoryRepoCache;
        }

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
            _memoryRepoCache.SetMemory((int)EnumMemoryType.FornecedorEndereco, fornecedorEndereco);
            return true;
        }
    }
}
