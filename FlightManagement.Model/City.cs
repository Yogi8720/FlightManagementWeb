using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Model
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public String Name { get; set; }
    }
}
