using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleValidationBackend.Classes;
using VehicleValidationBackend.Models;

namespace VehicleValidationBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class VehicleRequestController : ControllerBase
    {
        public IVehicleRequestHandler VehicleRequestHandler { get; }

        public VehicleRequestController(IVehicleRequestHandler vehicleRequestHandler)
        {
            VehicleRequestHandler = vehicleRequestHandler;
        }


        // GET api/vehiclerequest/test/5
        // Generate a VehicleRequest test reponse
        [HttpGet("{id}")]
        public ActionResult<VehicleRequest> Test(int id = 0)
        {
            return VehicleRequestHandler.Generate(id);
        }

        // POST: api/VehicleRequest/ProcessVehicle
        // Returns the validation result
        [HttpPost]
        public ProcessVehicleResponse ProcessVehicle([FromBody]VehicleRequest vehicleRequest)
        {
            return VehicleRequestHandler.Validate(vehicleRequest);
        }

    }
}
