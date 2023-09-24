using bookStore.Models;

namespace bookStore.Data.Services
{
    public interface IEditorasService
    {
        Task<IEnumerable<Editora>> GetAllAsync();

        Task<Editora> GetByIdAsync(int id);

        Task AddAsync(Editora editora);

        Task <Editora> UpdateAsync(int id, Editora novaEditora); 

        Task DeleteAsync(int id);
    }
}
