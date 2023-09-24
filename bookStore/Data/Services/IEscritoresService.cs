using bookStore.Models;

namespace bookStore.Data.Services
{
    public interface IEscritoresService
    {
        Task<IEnumerable<Escritor>> GetAllAsync();

        Task<Escritor> GetByIdAsync(int id);

        Task AddAsync(Escritor escritor);

        Task <Escritor> UpdateAsync(int id, Escritor novoEscritor); 

        Task DeleteAsync(int id);
    }
}
