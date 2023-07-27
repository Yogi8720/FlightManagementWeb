using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class Schedule
    {
        [Key]
        [ValidateNever]
        public int Id { get; set; }

        public int FlightNumber { get; set; }

        [ValidateNever]
        [ForeignKey("FlightNumber")]
        public Flight Flight { get; set; }

        public int RouteNumber { get; set; }

        [ValidateNever]
        [ForeignKey("RouteNumber")]
        public Route Route { get; set; }

        [ValidateNever]
        
        public string DepartureTime { get; set; }

        [ValidateNever]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        public string ArrivalTime { get; set; }

    }
}
