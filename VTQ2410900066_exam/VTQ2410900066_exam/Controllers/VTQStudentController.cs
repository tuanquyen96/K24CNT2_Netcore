using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VTQ2410900066_exam.Data;
using VTQ2410900066_exam.Models;

namespace VTQ2410900066_exam.Controllers;

public class VTQStudentController : Controller
{
    private readonly VTQDataSqlServer _context;

    public VTQStudentController(VTQDataSqlServer context) => _context = context;

    public async Task<IActionResult> Index() => View(await _context.VTQStudents.AsNoTracking().ToListAsync());

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();
        var item = await _context.VTQStudents.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return item == null ? NotFound() : View(item);
    }

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(VTQStudent item)
    {
        if (!ModelState.IsValid) return View(item);
        _context.Add(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var item = await _context.VTQStudents.FindAsync(id);
        return item == null ? NotFound() : View(item);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, VTQStudent item)
    {
        if (id != item.Id) return NotFound();
        if (!ModelState.IsValid) return View(item);
        _context.Update(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var item = await _context.VTQStudents.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return item == null ? NotFound() : View(item);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var item = await _context.VTQStudents.FindAsync(id);
        if (item != null) _context.VTQStudents.Remove(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
