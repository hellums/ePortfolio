# ePortfolio

This .NET Core C# solution includes 5 projects: 
- a Baker's Percentage console program,
- associated unit tests for the console program,
- a Baker's Percentage web API,
- a portfolio (ePortfolio) web app, and
- associated unit tests for the portfolio

The ePortfolio is a Blazor WebAssembly Single-Page App with an Azure CI pipeline using GitHub Actions. It highlights my software development experience (professional, academic, and personal). It also includes a link to a Blazor Server app that enables CRUD on a database of "PrintWorthy" swdev-related web links, backed by Azure AD user authentication and MongoDB on Atlas. The hosted ePortfolio and PrintWorthy web apps are in SDLC maintenance phase.

## Screen Shot (https://hellums-eportfolio.azurewebsites.com)
<p><img alt="API screenshot" width="600px" src="https://user-images.githubusercontent.com/83464025/174502724-bba411d8-7c4b-4a79-8ce4-897f839a4d86.png"></p>

## Why Blazor?

I chose Blazor for an ePortfolio because it has several purported advantages for a project like this:
- Blazor is Microsoft's newest Web framework technology, stable and powerful
- Blazor represents a more effective GUI for portfolio demonstration than GitHub repos 
- Blazor keeps native to C#, and does not rely on Javascript web frameworks for front-end rendering
- Blazor leverages the newest WebAssembly (Wasm) standard, as well as fundamental HTML, CSS, and Bootstrap
- Blazor Wasm SPA can be delivered from anywhere, including CDNs, without the need for a complicated backend stack
- Blazor is easily deployed from Visual Studio as an Azure hosted app where anyone can download it on any device
- Blazor can be integrated with a CI/CD pipeline to Azure using GitHub Actions

## Instructions

RECOMMENDATION: Shift-click or Ctrl-click on links to bring them up in new windows or tab

To see the ePortfolio Web application running live, go to my [ePortfolio site on Azure](https://hellums-eportfolio.azurewebsites.net), or use Docker to pull and run the [ePortfolio image on Docker Hub](https://hub.docker.com/r/hellums/eportfolio).
To see the Bakers Percentage API running live, go to my [BakersPercentage site on Azure](https://hellums-bakersapi.azurewebsites.net/api).

To clone, test, and run the console, web, and API programs on your local drive, do the following:

- create a new folder, such as "test", then run these commands
- > cd test
- > git clone https://github.com/hellums/ePortfolio.git
- > cd ePortfolio
- > dotnet test ePortfolio.sln

- > dotnet run -s ePortfolio.sln --project bakers/Bakers.csproj

- > dotnet run -s ePortfolio.sln --project BakersAPI/BakersAPI.csproj

- In a browser or tab, enter the URL link listed in the dotnet output, plus /api (or click https://localhost:7195/api) to see the instructions, or anything using the template provided: (https://localhost:7195/api/ciabatta/900 for example).
- To stop the API program, return to the command line and press Ctrl-C once or twice

- > dotnet run -s ePortfolio.sln --project ePortfolio.csproj

- In a browser or tab, enter the URL link listed in the dotnet output (or click https://localhost:7257) 
- To stop the ePortfolio program, return to the command line and press Ctrl-C once or twice

- To cleanup when done, cd back to where you created the test folder and remove it (and ePortfolio) using rmdir /s /q test (on Windows) or rm -rf test (on Mac or Linux)

You can also use Visual Studio to run the programs and associated tests from the IDE and automate the browser launch, by loading the ePortfolio.sln file in that folder (after cloning), and remove the folders afterwards from File Explorer (on Windows) or Finder (on Mac)
 
## Code Louisville Requirements List (for ePortfolio project)
RECOMMENDATION: Shift-click or Ctrl-click on links to bring them up in new windows or tab

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
- [X] Connect to an external/3rd party API and read data into your app: (In printworthy bookmarks private repo due to API key) _mongoClient = new MongoClient("mongodb+srv://printworthy")
- [X] Create [3 or more unit tests](https://github.com/hellums/ePortfolio/tree/root/ePortfolioTest) for your application
- [X] Use a LINQ query to retrieve information from a data structure (such as a list or array) or file (methods below from Printworthy, private repo):
        public string Delete(string referenceID)
        {
          _referenceTable.DeleteOne(x=>x.Id==referenceID);
            return "Deleted";
        }

        public Reference GetReference(string referenceID)
        {
            return _referenceTable.Find(x=>x.Id == referenceID).FirstOrDefault();
        }

        public List<Reference> GetReferences()
        {
            return _referenceTable.Find(FilterDefinition<Reference>.Empty).ToList();
        }

        public void SaveOrUpdate(Reference reference)
        {
            var referenceObj = _referenceTable.Find(x=>x.Id == reference.Id).FirstOrDefault();
            if (referenceObj == null)
            {
                _referenceTable.InsertOne(reference);
            }
            else
            {
                _referenceTable.ReplaceOne(x => x.Id == reference.Id, reference);
            }
        }

## Code Louisville Requirements List (for console project)
RECOMMENDATION: Shift-click or Ctrl-click on links to bring them up in new windows or tab

- [X] Project includes a [README file](https://github.com/hellums/bakers/blob/root/README.md) that explains the following:
  - [X] A one paragraph or longer description of what your project is about
  - [X] Any special instructions required for the reviewer to run your project
- [X] Implement a [“master loop”](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Controllers/PercentageController.cs#L11) console application, including choosing to exit the program
- [X] Create at least [one class and object instance](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.cs#L1) with populated data used in the application
- [X] Create an additional [class which inherits one or more properties](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.Ciabatta.cs#L3) from its parent
- [X] Create and call at least [3 functions or methods](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L47), at least one of which [returns a value used](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L45) in the application
- [X] Create a [dictionary or list](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L10), populate it with several values, [retrieve at least one value](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Controllers/PercentageController.cs#L13), and use it in your program
- [X] Implement a [log that records errors](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/Logger/Logger.cs#L16), invalid inputs, or other important events and writes them to a text file
- [X] Build a [conversion tool](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.cs#L20) that converts user input to another type and displays the results
- [X] Create [3 or more unit tests](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/BakersTest/PercentageModelTest.cs#L4)
- [X] Uses [interfaces and MVC architecture](https://github.com/hellums/bakers/blob/5aad293bc22abdc7f0d699225554acb3071999c0/bakers/Controllers/PercentageController.cs#L3) to separate UI from business logic and data layer
