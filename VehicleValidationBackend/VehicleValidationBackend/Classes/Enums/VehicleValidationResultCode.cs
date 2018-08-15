using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleValidationBackend.Classes.Enums
{
    public class VehicleValidationResultCode : Enumeration
    {
        public static VehicleValidationResultCode NotSpecified = new VehicleValidationResultCode(1, "Not specified");
        public static VehicleValidationResultCode Invalid = new VehicleValidationResultCode(2, "Invalid");
        public static VehicleValidationResultCode Valid = new VehicleValidationResultCode(3, "Valid");

        protected VehicleValidationResultCode() { }

        public VehicleValidationResultCode(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<VehicleValidationResultCode> List()
        {
            return new[] { NotSpecified, Invalid, Valid };
        }
    }

}
