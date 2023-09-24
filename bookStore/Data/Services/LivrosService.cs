using bookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Data.Services
{
    public class LivrosService : ILivrosService
    {
        private readonly AppDbContext _appDbContext;
        public LivrosService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Livro livro)
        {
            await _appDbContext.Livros.AddAsync(livro);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var resultado = await _appDbContext.Livros.FirstOrDefaultAsync(n => n.Id == id);
            _appDbContext.Livros.Remove(resultado);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            var resultado = await _appDbContext.Livros.ToListAsync();
            return resultado;
        }

        public async Task<Livro> GetByIdAsync(int id)
        {
            var result = await _appDbContext.Livros.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Livro> UpdateAsync(int id, Livro novoLivro)
        {
            _appDbContext.Update(novoLivro);
            await _appDbContext.SaveChangesAsync();
            return novoLivro;
        }
    }
}
