# manage-number

# Application to register and unregister numbers

The Manage Number is an ASP.NET Core WCF application that introduces a way to register, unregister numbers and consult how many numbers are left to be registered. This solves the problem for controling logical and physical numbers allocation to clients, allowing to register a specific number and remove it, when no longer used. It is a minimal version of what could be used on large phone operators, only allowing 15 numbers to be regustered. The application exposes a service that can be used by others in the future.

#### Author
- [Fernanda Montanari](https://github.com/fermontanari)

### To test the application

The application contains a Console screen loaded when executed, this screen allows to include or remove numbers, and contains a button to consult how many numbers are left to be registered. It can be executed through Visual Studio, or with Docker.

### Instructions to run the applications with Docker
1. Clone this repository
2. Go to the root folder and build the application with: docker build -t manage-number .
3. From the same folder, you can run the service: docker run -d --name managenumber-service manage-number
 
Note that currently Docker does not support running in containers a ASP.NET Core Console Application, once container is up, you can execute the console sepparetly.

### Instructions to run the applications without Docker (i.e. in the host OS)
1. Clone this repository
2. Open the solution file (sln) on Visual Studio
3. Build the solution
4. From ManageNumber.Presentation project, Run it.

### To build and run the app from comman line
1. Clone this repository
2. Go to the root folder and build the application with: MSBuild.exe ManageNumber.sln -t:Clean;Rebuild
3. To run the console app: ManageNumber.Presentation/bin/Debug/ManageNumber.Presentation.exe
