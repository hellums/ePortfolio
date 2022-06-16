using System.Net.Http.Json;

namespace ePortfolio.Pages
{
    public partial class About
    {
        private Example[]? examples;

        protected override async Task OnInitializedAsync() => examples = await Http.GetFromJsonAsync<Example[]>("data/examples.json");

        public class Example
        {
            public string? Subject { get; set; }
            public string? Language { get; set; }
            public string? Model { get; set; }
            public string? Scope { get; set; }
            public string? Database { get; set; }
        }
    }
}
