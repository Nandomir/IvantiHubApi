# IvantiHubApi

IvantiHubApi is an ASP.NET Core API application that allows you to calculate the coordinates of a triangle based on its row and column, and vice versa.
You can interact with the API via a basic JavaScript-based front-end or swagger.


## Prerequisites

- .NET SDK 6.0 or later
- A text editor or IDE (Visual Studio, Visual Studio Code, etc.)
  

## Getting Started

Clone the repository
```bash
git clone https://github.com/Nandomir/IvantiHubApi.git
```

Navigate to the project folder
```bash
cd IvantiHubApi
```

Run the following command to restore all NuGet packages.
```bash
dotnet restore
```

Execute the following command to run the application.
```bash
dotnet run
```

Your API should be running on https://localhost:<port>. 
The port by default is 5179 for HTTP and 7291 for HTTPS.


## Accessing the Front-End Page

Open your web browser and navigate to:
```bash
https://localhost:<port>/index.html
```
Replace <port> with the actual port number where your API is running.


## Using Swagger UI

To access the Swagger UI for testing API endpoints, open your web browser and go to:
```bash
https://localhost:<port>/swagger
```


## Endpoints

GET /api/Triangle/findCoordinates/{row}/{col}: Takes in a row and col and returns the coordinates of the triangle.
POST /api/triangle/findRowCol: Takes in the coordinates of the triangle and returns its row and col.


# Unit Tests

The IvantiHubApi.Tests project includes unit tests, aimed at verifying the functionality of individual components. The tests are written using xUnit and SpecFlow for Behavior-Driven Development (BDD) and make use of Gherkin syntax for clear, human-readable test cases.


## Structure

TriangleVerticesModelValidator.feature: Contains SpecFlow scenarios to validate TriangleVerticesModel.
TriangleService.feature: Contains SpecFlow scenarios for TriangleService methods, which include coordinate calculation and row/column identification.


## Running the Tests in Visual Studio

To run the unit tests in Visual Studio, follow these steps:

Open the project in Visual Studio.
Build the solution by pressing Ctrl+Shift+B or by going to Build -> Build Solution from the menu.
Once the build is successful, go to the Test menu and select Test Explorer.
In the Test Explorer window, you will see a list of all available tests.
You can:
Run all the tests by clicking on Run All at the top of the Test Explorer.
Run specific tests by right-clicking on a test or a set of tests and selecting Run Selected Tests.
Your tests will run, and you'll see the results displayed in the Test Explorer.
## Running the Tests in Visual Studio
