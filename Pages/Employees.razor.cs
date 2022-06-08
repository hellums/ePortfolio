using System.Net.Http.Json;

namespace ePortfolio.Pages
{
    public partial class Employees
    {
    private Worker[]? peeps;

        protected override async Task OnInitializedAsync()
        {
            peeps = await Http.GetFromJsonAsync<Worker[]>("data/employee.json");
        }

        public class Worker
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? StartDate { get; set; }
            public string? Title { get; set; }
            public int Salary { get; set; }
            public int BonusPercentage { get; set; }
            public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

            public string Working()
            { return ("Working"); }

            public string Working(string tasking) //overloading example
            { return (tasking); }

            public string CalculateRaise()
            {
                if (BonusPercentage == 0) { return (" None"); }
                else { return (Salary * BonusPercentage / 100).ToString(); }
            }
        }
    }
}
