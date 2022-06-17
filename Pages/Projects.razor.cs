using System.Net.Http.Json;

namespace ePortfolio.Pages
{
    public partial class Projects
    {
        private Project[]? projects;
        protected override async Task OnInitializedAsync()
        {
            projects = await Http.GetFromJsonAsync<Project[]>("data/projects.json");
        }
        public class Project
        {
            public string? Customer { get; set; }
            public string? System { get; set; }
            public string? Language { get; set; }
            public string? Detail { get; set; }
        }
    }
}
