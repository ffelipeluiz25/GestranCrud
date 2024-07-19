using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Enumeradores;
using CrudLuizFelipe.Model;
using CrudLuizFelipe.Repositories.Interface;
namespace CrudLuizFelipe.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {

        private readonly IMemoryRepository _memoryRepoCache;

        public FornecedorRepository(IMemoryRepository memoryRepoCache)
        {
            _memoryRepoCache = memoryRepoCache;
        }

        public IEnumerable<FornecedorDto> GetFornecedores()
        {
            var dynamic = _memoryRepoCache.GetMemory((int)EnumMemoryType.Fornecedor);

            //TODO:A ideia é utiliza o Mapper para DTOs
            var list = (IEnumerable<Fornecedor>)dynamic;
            var listDto = new List<FornecedorDto>();
            foreach (var item in list)
            {
                var fornecedorDto = new FornecedorDto();
                fornecedorDto.Id = item.Id;
                fornecedorDto.DataCriacao = item.DataCriacao;
                fornecedorDto.Nome = item.Nome;
                fornecedorDto.Cnpj = item.Cnpj;
                fornecedorDto.Telefone = item.Telefone;
                fornecedorDto.Email = item.Email;
                listDto.Add(fornecedorDto);
            }
            return listDto;
        }

        public FornecedorDto GetFornecedoresById(int id)
        {
            var dynamic = _memoryRepoCache.GetMemory((int)EnumMemoryType.Fornecedor);

            //TODO:A ideia é utiliza o Mapper para DTOs
            var list = (IEnumerable<Fornecedor>)dynamic;
            var listDto = new List<FornecedorDto>();
            foreach (var item in list)
            {
                var fornecedorDto = new FornecedorDto();
                fornecedorDto.Id = item.Id;
                fornecedorDto.DataCriacao = item.DataCriacao;
                fornecedorDto.Nome = item.Nome;
                fornecedorDto.Cnpj = item.Cnpj;
                fornecedorDto.Telefone = item.Telefone;
                fornecedorDto.Email = item.Email;
                listDto.Add(fornecedorDto);
            }

            var fornecedorById = listDto.FirstOrDefault(fornec => fornec.Id.Equals(id));
            return fornecedorById;
        }

        public IEnumerable<FornecedorDto> GetFornecedoresByParams(FornecedoresFiltroDto filter)
        {
            var dynamicFornecedores = _memoryRepoCache.GetMemory((int)EnumMemoryType.Fornecedor);
            var dynamicEndereco = _memoryRepoCache.GetMemory((int)EnumMemoryType.Endereco);
            var dynamicFornecedorEndereco = _memoryRepoCache.GetMemory((int)EnumMemoryType.FornecedorEndereco);

            //TODO:A ideia é utiliza o Mapper para DTOs
            var list = (IEnumerable<Fornecedor>)dynamicFornecedores;
            var listEndereco = (IEnumerable<Endereco>)dynamicEndereco;
            var listFornecedorEndereco = (IEnumerable<FornecedorEndereco>)dynamicFornecedorEndereco;
            var listDto = new List<FornecedorDto>();
            foreach (var item in list)
            {
                var fornecedorDto = new FornecedorDto();
                fornecedorDto.Id = item.Id;
                fornecedorDto.DataCriacao = item.DataCriacao;
                fornecedorDto.Nome = item.Nome;
                fornecedorDto.Cnpj = item.Cnpj;
                fornecedorDto.Telefone = item.Telefone;
                fornecedorDto.Email = item.Email;
                listDto.Add(fornecedorDto);
            }

            listDto = (from fornec in listDto
                       join forneEnd in listFornecedorEndereco on fornec.Id equals forneEnd.FornecedorId
                       join endereco in listEndereco on forneEnd.EnderecoId equals endereco.Id
                       where
                           fornec.Nome.Contains(filter.Nome)
                           && fornec.Cnpj.Equals(filter.Cnpj)
                           && endereco.Cidade.Equals(filter.Cidade)
                       select fornec
                       ).ToList();


            return listDto;
        }

        public bool Save(FornecedorDto fornecedorDto)
        {
            //TODO:A ideia é utiliza o Mapper para DTOs
            var list = new List<Fornecedor>();
            var dynamic = _memoryRepoCache.GetMemory((int)EnumMemoryType.Fornecedor);
            if (dynamic != null)
            {
                list = (List<Fornecedor>)dynamic;
            }
            var fornecedor = new Fornecedor();
            fornecedor.Id = fornecedorDto.Id;
            fornecedor.DataCriacao = DateTime.Now;
            fornecedor.Nome = fornecedorDto.Nome;
            fornecedor.Cnpj = fornecedorDto.Cnpj;
            fornecedor.Telefone = fornecedorDto.Telefone;
            fornecedor.Email = fornecedorDto.Email;

            list.Add(fornecedor);
            _memoryRepoCache.SetMemory((int)EnumMemoryType.Fornecedor, list);

            return true;
        }
    }
}
