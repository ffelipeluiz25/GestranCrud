using System.Collections.Generic;
using CrudLuizFelipe.Enumeradores;
using CrudLuizFelipe.Model;
using CrudLuizFelipe.Repositories.Interface;
using Microsoft.Extensions.Caching.Memory;
namespace CrudLuizFelipe.Repositories
{
    public class MemoryRepository : IMemoryRepository
    {
        private readonly IMemoryCache _memoryCache;

        public MemoryRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        #region Metodos

        public void RemoveMemory(int key)
        {
            switch (key)
            {
                case (int)EnumMemoryType.Fornecedor:
                    {
                        _memoryCache.Remove(key);
                        break;
                    }
                case (int)EnumMemoryType.FornecedorEndereco:
                    {
                        _memoryCache.Remove(key);
                        break;
                    }
                case (int)EnumMemoryType.Endereco:
                    {
                        _memoryCache.Remove(key);
                        break;
                    }
                default:
                    break;
            }
        }

        public void SetMemory(int key, dynamic obj)
        {
            switch (key)
            {
                case (int)EnumMemoryType.Fornecedor:
                    {
                        _memoryCache.Set(key, (List<Fornecedor>)obj);
                        break;
                    }
                case (int)EnumMemoryType.FornecedorEndereco:
                    {
                        _memoryCache.Set(key, (List<FornecedorEndereco>)obj);
                        break;
                    }
                case (int)EnumMemoryType.Endereco:
                    {
                        _memoryCache.Set(key, (List<Endereco>)obj);
                        break;
                    }
                default:
                    break;
            }

        }

        public void CreateMemory(int key)
        {
            switch (key)
            {
                case (int)EnumMemoryType.Fornecedor:
                    {
                        _memoryCache.CreateEntry(key);
                        break;
                    }
                case (int)EnumMemoryType.FornecedorEndereco:
                    {
                        _memoryCache.CreateEntry(key);
                        break;
                    }
                case (int)EnumMemoryType.Endereco:
                    {
                        _memoryCache.CreateEntry(key);
                        break;
                    }
                default:
                    break;
            }
        }

        public dynamic GetMemory(int key)
        {
            switch (key)
            {
                case (int)EnumMemoryType.Fornecedor:
                    {
                        return _memoryCache.Get(key);
                    }
                case (int)EnumMemoryType.FornecedorEndereco:
                    {
                        return _memoryCache.Get(key);
                    }
                case (int)EnumMemoryType.Endereco:
                    {
                        return _memoryCache.Get(key);
                    }
                default:
                    break;
            }

            return null;

        }

        #endregion

    }
}
