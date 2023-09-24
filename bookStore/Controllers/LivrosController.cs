using bookStore.Data;
using bookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Controllers
{
    public class LivrosController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public LivrosController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var livros = await _appDbContext.Livros.Include(n => n.Editora).Include(m => m.Escritor).OrderBy(o => o.Titulo).ToListAsync();
            return View(livros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Titulo, Escritor, Sinopse, Preco, URlImagem, DataLancamento, LivroCategora, Editora")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                return View(livro);
            }
            await _appDbContext.AddAsync(livro);
            return RedirectToAction(nameof(Index));
        }
    }
}
