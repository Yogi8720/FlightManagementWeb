using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class Flight
    {
        [Key]
        public int FlightNumber { get; set; }

        [Required]
        public string? AirlinesName { get; set; }

        [Required]
        public int SeatCapacity { get; set; }
    }
}
