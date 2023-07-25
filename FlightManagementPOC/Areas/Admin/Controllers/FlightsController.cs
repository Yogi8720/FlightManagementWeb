using FlightManagement.DataAccess.Repository.IRepositories;
using FlightManagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementPOC.Areas.Admin.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FlightsController(IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }

        // GET: FlightsController
        public ActionResult Index()
        {
            IEnumerable<Flight> flights = _unitOfWork.Flight.GetAll();
            return View(flights);
        }

        //GET Create
        public IActionResult Create()
        {
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Flight obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Flight.Add(obj);
                _unitOfWork.Save();
                //TempData["Success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET Edit
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var flight = _unitOfWork.Flight.GetFirstOrDefault(f => f.FlightNumber == id);
            return View(flight);
        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Flight flight)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Flight.Update(flight);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(flight);
        }

        //Delete
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var flight = _unitOfWork.Flight.GetFirstOrDefault(f => f.FlightNumber == id);
            _unitOfWork.Flight.Remove(flight);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
