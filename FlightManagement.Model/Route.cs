using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class Route
    {
        [Key]
        public int RouteNumber { get; set; }

        [Required]
        public string RouteName { get; set; }

        [Required]
        public string Source  { get; set; }

        [Required]
        public string Destination { get; set; }
    }
}
