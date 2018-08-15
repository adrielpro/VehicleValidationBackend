using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleValidationBackend.Classes.Enums;
using VehicleValidationBackend.Models;

namespace VehicleValidationBackend.Classes
{
    public interface IVehicleRequestHandler
    {
        VehicleRequest Generate(int id = 0);
        ProcessVehicleResponse Validate(VehicleRequest vehicleRequest);
    }

    //Implements here the logic of Vehicle Validation
    public class VehicleRequestHandler : IVehicleRequestHandler
    {
        //Generate a test VehicleRequest Model
        public VehicleRequest Generate(int id=0)
        {
            return new VehicleRequest() { VehicleId = id, Price = 1000, ManufacturerNameShort = "Manufacturer", Type = "Shoes" };
        }

        //Validate the VehicleRequest model and returns a ProcessVehicleResponse
        public ProcessVehicleResponse Validate(VehicleRequest vehicleRequest) {

            if (vehicleRequest == null)
                return new ProcessVehicleResponse() { VehicleId = 0, ReturnCode = VehicleValidationResultCode.Invalid };
            if (!ModelsValidator.IsValidModel(ref vehicleRequest))
            {
                return new ProcessVehicleResponse() { VehicleId = vehicleRequest.VehicleId, 
                            ReturnCode = VehicleValidationResultCode.Invalid };
            }
            return new ProcessVehicleResponse() { VehicleId = vehicleRequest.VehicleId, ReturnCode = VehicleValidationResultCode.Valid};
        }

    }
}
