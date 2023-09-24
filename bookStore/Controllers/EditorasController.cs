using bookStore.Data;
using bookStore.Data.Services;
using bookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Controllers
{
    public class EditorasController : Controller
    {
        private readonly IEditorasService _service;

        public EditorasController(IEditorasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var editoras = await _service.GetAllAsync();
            return View(editoras);
        }

        //Get: Editoras/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("URLLogo, NomeEditora, AnoFundacao, Slogan, Website")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                return View(editora);
            }
            await _service.AddAsync(editora);
            return RedirectToAction(nameof(Index));
        }

        //Get: Editoras/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var editoras = await _service.GetByIdAsync(id);

            if (editoras == null) return View("NotFound");
            return View(editoras);
        }

        //Get: Editoras/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var editoras = await _service.GetByIdAsync(id);
            if (editoras == null) return View("NotFound");
            return View(editoras);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("EditoraId, URLLogo, NomeEditora, AnoFundacao, Slogan, Website")] Editora editora)
        {
            if (id != editora.EditoraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            await _service.UpdateAsync(id, editora);
            return View(editora);
        }

        //Get: Editoras/Delete/1
        public async Task<IActionResult> Delete(int id)
        {

            var editoras = await _service.GetByIdAsync(id);
            if (editoras == null) return View("NotFound");
            return View(editoras);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var editoras = await _service.GetByIdAsync(id);
            if (editoras == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
