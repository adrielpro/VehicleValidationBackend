using VehicleValidationBackend.Classes.Enums;

namespace VehicleValidationBackend.Models
{
    public class ProcessVehicleResponse
    {
        public int VehicleId { get; set; }
        public VehicleValidationResultCode ReturnCode {get; set;}
    }
}
