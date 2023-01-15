using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using shop.Data;
using shop.Models;

namespace shop.Controllers;

public class ProductsController : Controller
{
    private readonly ProductsDbContext _db;
    public ProductsController(ProductsDbContext db)
    {
        _db = db;
    }
    public IActionResult Products()
    {
        IEnumerable<ProductsModel> productList = _db.Products.ToList();
        return View(productList);
    }
    // init? makes it nullable
    public IActionResult Product(int? id)
    {
        ProductsModel product = _db.Products.Find(id);
        return View(product);
    }
    [Authorize]
    public IActionResult Edit(int? id)
    {
        ProductsModel product = _db.Products.Find(id);
        return View(product);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(ProductsModel product)
    {
        _db.Products.Update(product);
        _db.SaveChanges();
        return RedirectToAction("Products");
    }
    [Authorize]
    public IActionResult Delete(int? id)
    {
        var product = _db.Products.Find(id);
        _db.Products.Remove(product);
        _db.SaveChanges();
        return RedirectToAction("Products");
    }

    [Authorize]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ProductsModel product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();
        return RedirectToAction("Products");
    }

    public IActionResult MyList()
    {
        var items = _db.Lists.Where(p => p.User == User.Identity.Name).ToList();
        var productList = new List<ProductsModel>();
        foreach(var item in items)
        {
            productList.Add(_db.Products.Find(item.ProductID));
        }

        return View(productList);
    }

    public IActionResult AddToList(int? id)
    {
        var ListItem = new ListsModel();
        ListItem.ProductID = Convert.ToInt32(id);
        ListItem.User = User.Identity.Name;
        _db.Lists.Add(ListItem);
        _db.SaveChanges();
        return RedirectToAction("Products");
    }
}