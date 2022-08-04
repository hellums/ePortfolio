# ePortfolio

I bake almost all our sandwich and artisan bread at home, using the "Baker's Percentage" method, with ingredients converted to weight in grams from volumes like cups and teaspoons. I wanted a program to do this so I wouldn't have to break out my baking notebook and the calculator on my phone, a manual processs that was also prone to human error. This resulted in:

- Excel worksheets to prototype the formulas for each bread type
- a [Razor web API engine](https://github.com/hellums/BakersAPI) that implemented the basic formulas and associated classes and methods
- a [Blazor interactive web UI](https://github.com/hellums/ePortfolio/blob/root/Pages/BakersPercentage.razor) and [class](https://github.com/hellums/ePortfolio/blob/root/Pages/BakersPercentage.razor.cs) that wrapped the formulas in a single page app or SPA using WebAssembly
- the same interacive UI as a [console program](https://github.com/hellums/Bakers) for desktop use
- associated [unit tests](https://github.com/hellums/ePortfolio/blob/root/ePortfolioTest/TestBakers.cs) to ensure sanity throughout SDLC changes
- continous test and deployment pipeline using [GitHub Actions](https://github.com/hellums/ePortfolio/actions) and [Azure CI](https://github.com/hellums/ePortfolio/blob/root/.github/workflows/root_hellums-eportfolio.yml)

I realized an Azure web site using Blazor provided a better UI and delivery platform for a personal software development portfolio than GitHub, so I moved those elements from GitHub as an additional wrapper around my Baker's Percentage app.

The API version of Bakers Percentage lives at my [BakersPercentage site on Azure](https://hellums-bakersapi.azurewebsites.net/api).

The web version and ePortfolio live at my [ePortfolio site on Azure](https://hellums-eportfolio.azurewebsites.net). 

It is also packaged up as a container at [ePortfolio image on Docker Hub](https://hub.docker.com/r/hellums/eportfolio).
