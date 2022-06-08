# ePortfolio

This program uses Blazor WebAssembly to create a personal ePortfolio of Razor pages and components representing my body of software development work (professional, academic, and personal). The Single Page App is posted to Azure Websites, and includes a link to a simple Blazor Serrver CRUD app with user authentication and a MongoDB on Atlas. This ePortfolio constitutes a wrapper for at least one deliverable project (a Baker's Percentage Engine) that is part of a Code Louisville bootcamp on C#, .NET, and object-oriented programming. It includes work from additional bootcamps on Python and Data Analysis, and the hosted app will remain as a living document, app, and repository with its own SDLC.

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

## Code Louisville Requirements List
- [X] Project includes a README file that explains the following:
- [X] A one paragraph or longer description of what your project is about
- [ ] Any special instructions required for the reviewer to run your project
- [X] Create at least [one class](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L12) and [object instance](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L5) with [populated data used in the application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Create and call at least 3 functions or methods: [1.](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Csharp.razor#L6) [2.](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Csharp.razor#L1) [3. ](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L86) [4. ](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L103), at least one of which [returns a value used in the application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L163)
- [X] Create a dictionary or list, [populate it with several values](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/wwwroot/data/examples.json#L1), retrieve at least one value, and [use it in your program](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Read data from an [external file, such as text, JSON,](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor.cs#L10) CSV, etc and [use that data in your application](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/Projects.razor#L24)
- [X] Connect to an external/3rd party API and [read data into your app](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/PrintWorthy.razor#L6)
- [X] Build a [conversion tool that converts user input to another type and displays it](https://github.com/hellums/ePortfolio/blob/c650eafc47f49c14031c88f6fb5f7ee919c1da99/Pages/BakersPercentage.razor#L164) (ex: converts cups to grams)
- [ ] Create 3 or more unit tests for your application
