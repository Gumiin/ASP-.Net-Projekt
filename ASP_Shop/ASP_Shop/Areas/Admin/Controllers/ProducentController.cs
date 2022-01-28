using Microsoft.AspNetCore.Mvc;
using ASP_Shop.Data;
using ASP_Shop.Models;
using ASP_Shop.Services;

namespace ASP_Shop.Controllers;
[Area("Admin")]
    public class ProducentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProducentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Producent> objProducentList = _unitOfWork.Producent.GetAll();
            return View(objProducentList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producent obj)
        {
        if (obj.Name == obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name");
        }
            if (ModelState.IsValid)
            {
                _unitOfWork.Producent.Add(obj);
                _unitOfWork.Save();
                TempData["succes"] = "Producent created successfully";
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
            var producentFromDbFirst = _unitOfWork.Producent.GetFirstOrDefault(u => u.Id == id);

            if (producentFromDbFirst == null)
            {
                return NotFound();
            }

            return View(producentFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Producent obj)
        {
        if (ModelState.IsValid)
            {
                _unitOfWork.Producent.Update(obj);
                _unitOfWork.Save();
                TempData["succes"] = "Producent edited successfully";
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

            var ProducentFromDbFirst = _unitOfWork.Producent.GetFirstOrDefault(u => u.Id == id);


            if (ProducentFromDbFirst == null)
            {
                return NotFound();
            }

            return View(ProducentFromDbFirst);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _unitOfWork.Producent.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Producent.Remove(obj);
            _unitOfWork.Save();
            TempData["succes"] = "Producent deleted successfully";
            return RedirectToAction("Index");

        }
    }
