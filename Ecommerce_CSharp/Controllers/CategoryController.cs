using Ecommerce_CSharp.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_CSharp.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext _db)
    {
        _context = _db;
    }

    public IActionResult Index()
    {
        List<Category> objectList = _context.Categories.ToList();
        return View(objectList);
    }
}