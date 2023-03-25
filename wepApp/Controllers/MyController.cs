using Entities;
using Microsoft.AspNetCore.Mvc;

namespace wepApp.Controllers
{
    public class MyController : Controller
    {
        private readonly IMyService _myService;

        public MyController(IMyService myService) => _myService = myService;

        public IActionResult Index()
        {
            var entities = _myService.GetAll();
            return View(entities);
        }

        public IActionResult Details(int id)
        {
            var entity = _myService.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Description")] MyEntity entity)
        {
            if (ModelState.IsValid)
            {
                _myService.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        public IActionResult Edit(int id)
        {
            var entity = _myService.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Description")] MyEntity entity)
        {
            if (id != entity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _myService.Update(entity);
                return RedirectToAction(nameof(Index));
            }

            return View(entity);
        }

        public IActionResult Delete(int id)
        {
            var entity = _myService.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var entity = _myService.GetById(id);
            _myService.Delete(entity);
            return RedirectToAction(nameof(Index));
        }
    }
}

    