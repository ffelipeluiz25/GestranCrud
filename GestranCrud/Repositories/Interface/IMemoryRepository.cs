using CrudLuizFelipe.Model;
namespace CrudLuizFelipe.Repositories.Interface
{
    public interface IMemoryRepository
    {
        void RemoveMemory(int key);
        void SetMemory(int key, dynamic obj);
        void CreateMemory(int key);
        dynamic GetMemory(int key);
    }
}
