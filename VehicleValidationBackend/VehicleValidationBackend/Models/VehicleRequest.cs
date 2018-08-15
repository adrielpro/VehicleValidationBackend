using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleValidationBackend.Models
{
    public class VehicleRequest
    {
        [Required]
        public int VehicleId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Type { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string ManufacturerNameShort { get; set; }
        [Required]
        public decimal? Price { get; set; }
    }

}
