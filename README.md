# ePortfolio

This program uses Blazor WebAssembly to create a personal ePortfolio of Razor pages and components representing my body of software development work (professional, academic, and personal). The Single Page App is posted to Azure Websites and containerized on Docker Hub, and includes a link to a simple Blazor Server CRUD app with basic AD user authentication and a MongoDB on Atlas. This ePortfolio constitutes a wrapper for at least one deliverable project (a Baker's Percentage Engine) that is part of a Code Louisville bootcamp on C#, .NET, and object-oriented programming. It includes work from additional bootcamps on Python and Data Analysis, and the hosted app will remain as a living document, app, and repository with its own SDLC.

## Screen Shot
<p><img alt="API screenshot" width="600px" src="https://user-images.githubusercontent.com/83464025/174502724-bba411d8-7c4b-4a79-8ce4-897f839a4d86.png"></p>

## Why Blazor?

I chose Blazor because it has several purported advantages for a project like this:
- Blazor leverages the newest WebAssembly (Wasm) standard, as well as fundamental HTML, CSS, Bootstrap, Open Iconic, and Javascript
- Blazor provides a Full Stack open web development framework for C# (vs Javascript's Angular, Vue, and React, or Python's Django/Flask)
- Blazor is new and fresh and shiny, from a technology and software development perspective
- A Blazor ePortfolio and the underlying C# project satisfy the course requirements of the bootcamp
- A Blazor ePortfolio serves a valid business need for me personally
- A Blazor ePortfolio can be delivered from anywhere, including CDNs, without the need for a complicated backend stack
- A Blazor ePortfolio is easily deployed from Visual Studio to an Azure hosted app where anyone can download it on any device
- A Blazor ePortfolio can be integrated with a CI/CD pipeline to Azure
- A Blazor ePortfolio can easily be decoupled from Github or a .NET server
- A Blazor ePortfolio is a more user-friendly interface, as an SPA, (with less "noise") than Github (especially for an ePortfolio)

## Instructions
To see the program running live, go to my [ePortfolio site on Azure](https://hellums-eportfolio.azurewebsites.net), or use Docker to pull and run the [ePortfolio image on Docker Hub](https://hub.docker.com/r/hellums/eportfolio)


To clone and run the program on your local system, do the following:

- create a new folder, such as "test", then run these commands
- > cd test
- > git clone https://github.com/hellums/ePortfolio.git
- > cd ePortfolio
- > dotnet run

- In a browser or tab, go the the link listed in the dotnet output (http://localhost:7257 for example) 


You can also use Visual Studio to run from the IDE and automate the browser launch, by loading the ePortfolio.sln file in that folder (after cloning)
 
## Code Louisville Requirements List
- [X] Project includes a README file that explains the following:
- [X] A one paragraph or longer description of what your project is about
- [X] Any special instructions required for the reviewer to run your project
- [X] Implement a “master loop” console application, including choosing to exit the program (in separate repo)
- [X] Create at least [one class](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L12) and [object instance](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L10) with [populated data used in the application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Create an additional class which inherits one or more properties from its parent
- [X] Create and call at least 3 functions or methods: [1.](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Csharp.razor#L6) [2.](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Csharp.razor#L1) [3. ](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L86) [4. ](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L103), at least one of which [returns a value used in the application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L163)
- [X] Create a dictionary or list, [populate it with several values](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/wwwroot/data/examples.json#L1), retrieve at least one value, and [use it in your program](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Implement a log that records errors, invalid inputs, or other important events and writes them to a text file
- [X] Read data from an [external file, such as text, JSON,](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L10) CSV, etc and [use that data in your application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Connect to an external/3rd party API and [read data into your app](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/PrintWorthy.razor#L6) (separate repo)
- [X] Build a [conversion tool that converts user input to another type and displays it](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L164) (ex: converts cups to grams)
- [X] Connect to an [external/3rd party API and read data into your app](https://github.com/hellums/PrintWorthy/blob/ab6b3c120c107285b0d68c1e4cae707df751bbdc/PrintWorthy/Service/ReferenceService.cs#L15): _mongoClient = new MongoClient("mongodb+srv://printworthy")
- [X] Use a [LINQ query to retrieve information](https://github.com/hellums/PrintWorthy/blob/ab6b3c120c107285b0d68c1e4cae707df751bbdc/PrintWorthy/Service/ReferenceService.cs#L26) from a data structure (such as a list or array) or file: return _referenceTable.Find(x=>x.Id == referenceID).FirstOrDefault();
- [X] Create [3 or more unit tests](https://github.com/hellums/ePortfolio/tree/root/ePortfolioTest) for your application

