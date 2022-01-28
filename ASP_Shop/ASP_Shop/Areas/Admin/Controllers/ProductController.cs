using Microsoft.AspNetCore.Mvc;
using ASP_Shop.Data;
using ASP_Shop.Models;
using ASP_Shop.Services;

namespace ASP_Shop.Controllers;
[Area("Admin")]
public class ProductController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public ProductController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        IEnumerable<Product> objProductList = _unitOfWork.Product.GetAll();
        return View(objProductList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Product.Add(obj);
            _unitOfWork.Save();
            TempData["succes"] = "Product created successfully";
            return RedirectToAction("Index");
        }
        return View(obj);

    }

    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var productFromDbFirst = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);

        if (productFromDbFirst == null)
        {
            return NotFound();
        }

        return View(productFromDbFirst);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Product obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Product.Update(obj);
            _unitOfWork.Save();
            TempData["succes"] = "v edited successfully";
            return RedirectToAction("Index");
        }
        return View(obj);

    }

    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var productFromDbFirst = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);


        if (productFromDbFirst == null)
        {
            return NotFound();
        }

        return View(productFromDbFirst);

    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int? id)
    {
        var obj = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.Product.Remove(obj);
        _unitOfWork.Save();
        TempData["succes"] = "Product deleted successfully";
        return RedirectToAction("Index");

    }
}
