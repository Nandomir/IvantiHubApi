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
