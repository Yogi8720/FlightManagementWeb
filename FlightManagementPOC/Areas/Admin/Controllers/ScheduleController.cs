using FlightManagement.DataAccess.Repository;
using FlightManagement.DataAccess.Repository.IRepositories;
using FlightManagement.Model;
using FlightManagement.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Composition.Convention;

namespace FlightManagementPOC.Areas.Admin.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ScheduleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: ScheduleController
        
        public ActionResult Index()
        {
            IEnumerable<Schedule> schedules = _unitOfWork.Schedule.GetAll(IncludeProperties: "Flight,Route");
            return View(schedules);
        }

        //GET Upsert
        public IActionResult Upsert(int? id)
        {
            ScheduleVM scheduleVM = new()
            {
                Schedule = new(),
                FlightList = _unitOfWork.Flight.GetAll().Select(
                    u => new SelectListItem
                    {
                        Text = u.AirlinesName,
                        Value = u.FlightNumber.ToString()
                    }),
                RouteList = _unitOfWork.Route.GetAll().Select(
                    u => new SelectListItem
                    {
                        Text = u.RouteName,
                        Value = u.RouteNumber.ToString()
                    })
            };
            if(id==null || id == 0)
            {
                return View(scheduleVM);
            }
            else
            {
                scheduleVM.Schedule = _unitOfWork.Schedule.GetFirstOrDefault(a => a.Id == id);
                return View(scheduleVM);
            }
        }

        //POST Upsert
        [HttpPost]
        public IActionResult Upsert(ScheduleVM scheduleVM)
        {
            if(ModelState.IsValid)
            {
                if(scheduleVM.Schedule.Id == 0)
                {
                    DateTime ArrivalDate = DateTime.Parse(scheduleVM.Schedule.ArrivalTime);
                    scheduleVM.Schedule.ArrivalTime = (ArrivalDate).ToString();
                    _unitOfWork.Schedule.Add(scheduleVM.Schedule);
                }
                else
                {
                    _unitOfWork.Schedule.Update(scheduleVM.Schedule);
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var schedule = _unitOfWork.Schedule.GetFirstOrDefault(c => c.Id == id);
            _unitOfWork.Schedule.Remove(schedule);
            _unitOfWork.Save();
            //TempData["Success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
