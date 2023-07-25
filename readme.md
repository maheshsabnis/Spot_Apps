# ASP.NET Core 7
- Mcrosoft.NetCore.App
	- the .NET Runtime	
- Microsoft.AspNetCore.App
	- ASP.NET Core 	

# WebApplication Builder
	- Services
		- Dependency Container, Provides using IServiceColleciton Contract
			- ServiceDescriptor class
				- Decide an Activation for the Dependency
					- Singleton
					- Scopped
					- Transient
	- Configuration
	- Socket
	- Middlewares
		- Builder for COnfiguring Middlewares in HTTP Pipeline that manages Request and Respons (aka HttpContext)

# API COntroller
	- ControllerBase
		- BAse class for API Controller
			- Uses ROuting to MAp HTTP Request to HTTP Action Method
				- HTTP GET, POST, PUT, and DELETE

		-  Action Method
				- A Method that will be invoked based on the Http REquest
						- Action Delegate with ExecuteAsync() Method
				- IActionResult INterface Cotractn
		- HTTP Response Methods
			- Ok(), NotFOund(), Conflict(), BadRequest(), etc.
			- File Operations
		- Property System
			- HttpRequest, HttpResponse
			- MOdelState
				- For Model VAlidation
			- ROuteData	
				- USed to Read the Http Route	INformation
					- https://SREVER/api/COntrollerClass/{PARAMETERS}	
- ApiControllerAttribute class
	- use to Read HTTP POST and PUT Request and Map Data from HTTP BOdy to the CLR Object (Entity Object / POCO )	for Write OPerations
	- 
- HTTP Template CLasses
	- HttpGet
	- HttpPost
	- HttPut
	- HttpDelete
		
# Microservice as Technology

1. Deployment COnfigurtion
	- Docker for on Premises
	- Kubernetes for Multiple Microservices on Cluster
		- Docker-Desktop
		- Docker Repository
			- Docker Hub
			- Azure COntainer Registry aka ACR
		- Cluster
			- Docker-Desktop, a Single Node Cluster
			- Azure Kubernetes Service aka AKS
	- CI/CD Pipeline
2. DataSTore Strategies
3. Sharing Data Across Microservices
	- Communication Across Microservices
		- Sync
			- HTTP COmminicaton across Microservices
			- BLOCKs the execution
		- Async
			- Pattern for Data Sharing using one of the following
				- RabbitMQ
				- Azure Service Bus
				- Kafka
4. Resilient Design
	- Retry Policies
	- Fallback
5. Discovery with Gateways
6. Security

# Docker
- Virtiuaozation Host for the Microservices (not limitted only for them)
- Docker Commands
	- CLI Commands for Image and Container Management
	- Login to the Repository
		- docker login	
	- Build an Image
		- Navigate to the pathe where 'Dockerfile' exist
		- docker build .-t [IMAGE-NAME]:[TAG]
			- -t is the tag switch
			- IMAGE-NAME, the name of the image always in lower case
			- TAG, the version of the image
		- Running an image in the container
			- docker run -p [PORT-FROM-HOST-MACHINE]:[PORT-EXPOSED-BY-CONTAINER] --nam [CONTAINER-NAME]  [IMAGE-NAME]:[TAG]
				- PORT-FROM-HOST-MACHINE, using this port the API Running inside the container canbe accessed
				- PORT-EXPOSED-BY-CONTAINER, mentioned in Dockerfile
				- CONTAINER-NAME, the Unique name in lower case in which the docker image is running
		- Running Container and hence an image in background
			- docker run  -it -p [PORT-FROM-HOST-MACHINE]:[PORT-EXPOSED-BY-CONTAINER] --nam [CONTAINER-NAME]  [IMAGE-NAME]:[TAG] 
		- Running an image in Interactice Mode, we can access the OS prompt of the Conatiner
			- docker run -p [PORT-FROM-HOST-MACHINE]:[PORT-EXPOSED-BY-CONTAINER] --nam [CONTAINER-NAME]  [IMAGE-NAME]:[TAG] 
		- Process of Removing an Image
			- If an Image is in Use then stop container
				- docker stop [CONTAINER-NAME] | [CONTAINER-ID]
			- Remove the Container
				- docker rm  [CONTAINER-NAME] | [CONTAINER-ID]
			- Remove the Image
				- docker rmi  [IMAGE-NAME]:[TAG]
		- List all Images
			- docker images
		- LIst all Containers
			- docker ps
		- LIst of all allocated contaiers (Containers in Use)
			- docker ps -a
		- Making docker image ready for deployment
			- Tag the image to the Repository NAme
				- docker tag [IMAGE-NAME]:[TAG] [REPOSITORY-NAME]/[IMAGE-NAME]:[TAG]
			- PUSH the image to the Repository
				- docker push [REPOSITORY-NAME]/[IMAGE-NAME]:[TAG]
			- Pull an image
				-   docker pull [REPOSITORY-NAME]/[IMAGE-NAME]:[TAG]
- Docker Repository
		- https://hub.docker.com	

# DOcker COmpose
- Build and Run Multiple Images
	- Allocate the Processor
	- Allocate memory
	- Register Network Resources on-premises
- docker-compose.yml file
	- uses individual docker files for each service
	- BUild IMages
	- Allocate Resources
	- COnfigure Network
	- STart Images by allocating ports
- Commands
	- docker-compose up
		- load Dockerfile for each service
		- BUild Image
		- If exists any dependencies then those will be resolved
		- ALlocate Network Resources
		- Expose Services on Ports
	- docker-compose down

# Best Practices while working with Microservices
- Database
	- MUST be avaialble from the public Endpoint
		- Cloud	
	- ENtityFrameworkCore, the ORM
		- Microsoft.EnttyFrameworkCore 
		- Microsoft.EnttyFrameworkCore.SqlServer
		- Microsoft.EnttyFrameworkCore.Relational
		- Microsoft.EnttyFrameworkCore.Design
		- Microsoft.EnttyFrameworkCore.Tools  
- Publishing Microservice for Production
	- Exposing Microservices with Gateway
		- Programatically
			- Create Gateway Explicitly
				- Ocelot
			- Up-time management of Microservices
				- Retry Policies
					- Resiliancy 
				- Circuit Breaker Pattern 
		- From the deployment ENv
			- Serverless 
	- Communication Pattern Across Microservices, DDD
		- Synchronous
			- HTTP COmmuncation across, 
		- Async
			- Infra Services
				- RabbitMQ
				- ASB
				- SQS
				- Kafka
			




