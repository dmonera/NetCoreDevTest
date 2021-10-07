# NetCoreDevTest

## Summary
The current endpoint does not serve data in the format requred and is known to be slow and unresponsive.

## Task
Extending the existing solution we need you to:
1. Create a Products API Controller  
2. Consume the existing data enpoint as inventory items
3. Map the inventory items into Product objects / models as defined below
4. Return the all Products within the Products API Controller 

### Things to consider
* Performance, as the data endpoint is unreliable 
* Testable code


## Instructions
Please fork this repository and create a Pull Request back into the main branch once work is complete.

## Information 

### Data Endpoint
https://virtserver.swaggerhub.com/Ethisys/DevTestAPI/1.0.0/inventory


## Internal Model 
### Product 
#### Properties:
* ID : GUID
* ProductName: string
* DateAvailable: DateTime
* Manufacturer: Manufacturer

### Manufacturer 
#### Properties:
* ManufacturerName: string
* ManufacturerUrl: string
* ManufacturerPhone: string

