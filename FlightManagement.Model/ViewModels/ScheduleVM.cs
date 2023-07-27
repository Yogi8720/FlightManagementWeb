using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        [ValidateNever]
        public Schedule Schedule { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> FlightList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> RouteList { get; set; }
    }
}
