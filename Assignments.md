#Date: 25-July-2023

1. Create 2 APIs for Performing FOllowing OPerations
	- Create an XML File on the server that will store information of Products
	- The First API will Open the XML file on the server and will read products based on CategoryName that is send by the CLient App using HTTP Get Request
		- THere SHoule be Mutiple REad OPerations based on criterias as follows
			- CategoryName
			- ManufacturerName
			- ProductName
			- All POsiible AND and OR Combinations on above criterias
	- The Second API should update the Record from XML Document
		- xLinq

2. DOckerize these APIs
			
# Date: 26-July-2023
1. Enhance the Gateway app to add multiple Microservices in DOwnstream  w/o unloading gateway app
2. IMplement this on the XML Assignment of Yesterday

 
# Date:27-July-2023

1. Enhance the Microservices on 25-July-2023 based on the following requiements
	- The First Microcervices will create a new Product using the Product Service and it will be stored into the XML Data Store, Once the XML Data Store is updated with this new data, this data will be written in the Messaging Queue Success-Queue
		- If the XML Data STore failed to update then these failed entries of Products MUST be witten into the Failed-Queue  
	- The Second Microservice will read the data from the Queue and show it to the client (Swagger) as the newly created product
	- THe THird MIcroservice (e.g. Audit Service) will show all the accepted products and Failed Produts from the Success-Queue and Failed-Queue and these produts can be shown on UI (Swagger)
