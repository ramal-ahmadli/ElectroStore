using ElectroStore.Business.Abstarct;
using ElectroStore.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ElectroStore.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ITechnolgyService _technolgyService;

		public DefaultController(ITechnolgyService technolgyService)
		{
			_technolgyService = technolgyService;
		}

		public IActionResult Index()
        {
            var values = _technolgyService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TechnolgyDTO p) 
        {
            _technolgyService.Insert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _technolgyService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(TechnolgyDTO p)
        {
            _technolgyService.Update(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _technolgyService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
