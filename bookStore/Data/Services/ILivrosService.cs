using bookStore.Models;

namespace bookStore.Data.Services
{
    public interface ILivrosService
    {
        Task<IEnumerable<Livro>> GetAllAsync();

        Task<Livro> GetByIdAsync(int id);

        Task AddAsync(Livro livro);

        Task <Livro> UpdateAsync(int id, Livro livro); 

        Task DeleteAsync(int id);
    }
}
