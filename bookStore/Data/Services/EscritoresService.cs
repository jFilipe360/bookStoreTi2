using bookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Data.Services
{
    public class EscritoresService : IEscritoresService
    {
        private readonly AppDbContext _appDbContext;
        public EscritoresService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Escritor escritor)
        {
            await _appDbContext.Escritores.AddAsync(escritor);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var resultado = await _appDbContext.Escritores.FirstOrDefaultAsync(n => n.EscritorId == id);
            _appDbContext.Escritores.Remove(resultado);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Escritor>> GetAllAsync()
        {
            var resultado = await _appDbContext.Escritores.ToListAsync();
            return resultado;
        }

        public async Task<Escritor> GetByIdAsync(int id)
        {
            var result = await _appDbContext.Escritores.FirstOrDefaultAsync(n => n.EscritorId == id);
            return result;
        }

        public async Task<Escritor> UpdateAsync(int id, Escritor novoEscritor)
        {
            _appDbContext.Update(novoEscritor);
            await _appDbContext.SaveChangesAsync();
            return novoEscritor;
        }
    }
}
