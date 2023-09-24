using bookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Data.Services
{
    public class EditorasService : IEditorasService
    {
        private readonly AppDbContext _appDbContext;
        public EditorasService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Editora editora)
        {
            await _appDbContext.Editoras.AddAsync(editora);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var resultado = await _appDbContext.Editoras.FirstOrDefaultAsync(n => n.EditoraId == id);
            _appDbContext.Editoras.Remove(resultado);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Editora>> GetAllAsync()
        {
            var resultado = await _appDbContext.Editoras.ToListAsync();
            return resultado;
        }

        public async Task<Editora> GetByIdAsync(int id)
        {
            var result = await _appDbContext.Editoras.FirstOrDefaultAsync(n => n.EditoraId == id);
            return result;
        }

        public async Task<Editora> UpdateAsync(int id, Editora novaEditora)
        {
            _appDbContext.Update(novaEditora);
            await _appDbContext.SaveChangesAsync();
            return novaEditora;
        }
    }
}
