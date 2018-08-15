# VehicleValidationBackend



#API DOCUMENTATION
#TEST
#----------------------
Return json data about a single Vehicle
URL
/api/VehicleRequest/test/:id

Method:
GET

URL Params
id=[integer]

Data Params
None

Success Response:
  Code: 200
  Content: {
    "vehicleId": [id]
    "type": "Shoes",
    "manufacturerNameShort": "Manufacturer",
    "price": 1000
}

Error Response:
  Code: 404 Not Found

#PROCESSVEHICLE
#----------------------
URL
/api/vehiclerequest/processVehicle

Method:
POST

URL Params
None

Data Params
VehicleRequest {
    vehicleId = [integer]
    type = [string],
    manufacturerNameShort = [string],
    price: [decimal]
}

Success Response:
  Code: 200
  Content: 
  {
    "vehicleId": [vehicleId],
    "returnCode": {
        "name": ["Invalid"]/["Valid"],
        "id": [2]/[3]
    }
  }
Error Respones:
  Code: 404 not Found
  or
  Code: 500 Internal Server error
