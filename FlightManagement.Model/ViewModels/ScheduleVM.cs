using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model.ViewModels
{
    public class ScheduleVM
    {
        public Schedule Schedule { get; set; }

        public IEnumerable<SelectListItem> FlightList { get; set; }

        public IEnumerable<SelectListItem> RouteList { get; set; }
    }
}
