using FlightManagement.DataAccess.Repository.IRepositories;
using FlightManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Route = FlightManagement.Model.Route;

namespace FlightManagementPOC.Areas.Admin.Controllers
{
    public class RoutesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoutesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: FlightsController
        public ActionResult Index()
        {
            IEnumerable<Route> routes = _unitOfWork.Route.GetAll();
            return View(routes);
        }

        //GET Create
        public IActionResult Create()
        {
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Route obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Route.Add(obj);
                _unitOfWork.Save();
                //TempData["Success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var route = _unitOfWork.Route.GetFirstOrDefault(f => f.RouteNumber == id);
            return View(route);
        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Route route)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Route.Update(route);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(route);
        }

        //Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var route = _unitOfWork.Route.GetFirstOrDefault(f => f.RouteNumber == id);
            _unitOfWork.Route.Remove(route);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
