using Ecommerce_CSharp.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_CSharp.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext db)
    {
        _context = db;
    }

    public IActionResult Index()
    {
        List<Category> objectList = _context.Categories.ToList();
        return View(objectList);
    }
    
    [HttpPost]
    public IActionResult Create(Category obj)
    {
        // _context.Categories.Add(obj);
        // _context.SaveChanges();
        // return RedirectToAction("Index");
        return View();
    }
}