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
        public int Id { get; set; }

        public int FlightNumber { get; set; }

        [ValidateNever]
        [ForeignKey("FlightNumber")]
        public Flight Flight { get; set; }

        public int RouteNumber { get; set; }

        [ValidateNever]
        [ForeignKey("RouteNumber")]
        public Route Route { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

    }
}
