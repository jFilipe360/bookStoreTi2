using bookStore.Data;
using bookStore.Data.Services;
using bookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Controllers
{
    public class EscritoresController : Controller
    {
        private readonly IEscritoresService _service;

        public EscritoresController(IEscritoresService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var escritores = await _service.GetAllAsync();
            return View(escritores);
        }


        //Get: Escritores/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("URLFoto, NomeCompleto, Biografia")]Escritor escritor)
        {
            if (ModelState.IsValid)
            {
                return View(escritor);
            }
            await _service.AddAsync(escritor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Escritores/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var escritorDetalhes = await _service.GetByIdAsync(id);

            if (escritorDetalhes == null) return View("NotFound");
            return View(escritorDetalhes);
        }

        //Get: Escritores/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var escritorDetails = await _service.GetByIdAsync(id);
            if (escritorDetails == null) return View("NotFound");
            return View(escritorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("EscritorId,NomeCompleto,URLFoto,Biografia")] Escritor escritor)
        {
            if (id != escritor.EscritorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            await _service.UpdateAsync(id, escritor);
            return View(escritor);
        }

        //Get: Escritores/Delete/1
        public async Task<IActionResult> Delete(int id)
        {

            var escritores = await _service.GetByIdAsync(id);
            if (escritores == null) return View("NotFound");
            return View(escritores);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var escritores = await _service.GetByIdAsync(id);
            if (escritores == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
