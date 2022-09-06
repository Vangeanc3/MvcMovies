using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class CadastroController : Controller
    {
        private readonly CadastroContext _context;

        public CadastroController(CadastroContext context)
        {
            _context = context;
        }

        //// GET: Gerentes
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Cadastros.ToListAsync());
        //}

        //// GET: Gerentes/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Cadastros == null)
        //    {
        //        return NotFound();
        //    }

        //    var cadastro = await _context.Cadastros
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (cadastro == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cadastro);
        //}

        //// GET: Gerentes/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: cadastros/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id, Nome, Assunto, Proposta, Data")] Cadastro cadastro)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(cadastro);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(cadastro);
        //}

        //// GET: Gerentes/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Cadastros == null)
        //    {
        //        return NotFound();
        //    }

        //    var cadastro = await _context.Cadastros.FindAsync(id);
        //    if (cadastro == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(cadastro);
        //}

        //// POST: Gerentes/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id, Nome, Assunto, Proposta, Data")] Cadastro cadastro)
        //{
        //    if (id != cadastro.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(cadastro);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!GerenteExists(cadastro.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(cadastro);
        //}

        //// GET: Gerentes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Cadastros == null)
        //    {
        //        return NotFound();
        //    }

        //    var cadastro = await _context.Cadastros
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (cadastro == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cadastro);
        //}

        //// POST: Gerentes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Cadastros == null)
        //    {
        //        return Problem("Entity set 'GerenteContext.Gerente'  is null.");
        //    }
        //    var cadastro = await _context.Cadastros.FindAsync(id);
        //    if (cadastro != null)
        //    {
        //        _context.Cadastros.Remove(cadastro);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool GerenteExists(int id)
        //{
        //    return _context.Cadastros.Any(e => e.Id == id);
        //}











        // GET: CADASTROS

        public async Task<IActionResult> Index()
        {
            return _context.Cadastros != null ?
                View(await _context.Cadastros.ToListAsync()) :
                Problem("Está nulo");
        }

        // GET: CADASTROS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        //GET: CADASTROS/CREATE

        public IActionResult Create()
        {
            return View();
        }

        //POST: CADASTROS/CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Assunto,Proposta,Data")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: CADASTROS/EDIT/5
        public async Task<IActionResult> Edit(int? id)
        {    
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }
            
            var cadastro = await _context.Cadastros.FindAsync(id);

            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        //POST: CADASTROS/EDIT/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Assunto,Proposta,Data")] Cadastro cadastro)
        {
            if (id != cadastro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExiste(cadastro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: CADASTROS/DELETE/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        // POST: CADASTROS/DELETE/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id) { 
            if (_context.Cadastros == null)
            {
                return Problem("Entity set 'GerenteContext.Gerente'  is null.");
            }
            var cadastro = await _context.Cadastros.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastros.Remove(cadastro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExiste(int id)
        {
            return (_context.Cadastros?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
