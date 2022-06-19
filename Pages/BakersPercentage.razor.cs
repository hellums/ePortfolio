using Microsoft.AspNetCore.Components;

namespace ePortfolio.Pages
{
    public partial class BakersPercentage   //this class calculates amount of each ingredient by bread type based on target dough mass
    {
        public int mass = 600;
        public string breadType = "";
        public double waterPercent = 63.0d; //hydration is 63% of flour weight for default type: sandwich
        public double yeastPercent = 1.2d;  //yeast is 1.2% of flour weight, etc.
        public double saltPercent = 1.0d;
        public double sugarPercent = 3.5d;
        public double fatPercent = 8.0d;
        public double flourAmount = 0.0d;
        public double waterAmount = 0.0d;
        public double yeastAmount = 0.0d;
        public double saltAmount = 0.0d;
        public double sugarAmount = 0.0d;
        public double fatAmount = 0.0d;

        protected override void OnInitialized()
        {
            CalculateIngredients();
        }

        public void IncrementCount()
        {
            mass += 50;
            CalculateIngredients();
        }
        public void DecrementCount()
        {
            mass -= 50;
            CalculateIngredients();
        }

        public void ResetWeight()
        {
            mass = 600;
            CalculateIngredients();
        }

        public void CalculateDough(ChangeEventArgs e)
        {
            string selectedBread = e.Value.ToString();
            switch (selectedBread)
            {
                case "Sandwich": //63% hydration
                    waterPercent = 63.0d;
                    yeastPercent = 1.2d;
                    saltPercent = 1.0d;
                    sugarPercent = 3.5d;
                    fatPercent = 8.0d;
                    break;
                case "Focaccia": //90% hydration
                    waterPercent = 90.0d;
                    yeastPercent = .75d;
                    saltPercent = 3.5d;
                    sugarPercent = 0.0d;
                    fatPercent = 9.4d;
                    break;
                case "Ciabatta": //82% hydration, etc.
                    waterPercent = 82.0d;
                    yeastPercent = 0.4d;
                    saltPercent = 2.2d;
                    sugarPercent = 0.0d;
                    fatPercent = 0.0d;
                    break;
                case "French":
                    waterPercent = 66.0d;
                    yeastPercent = 1.25d;
                    saltPercent = 2.0d;
                    sugarPercent = 0.0d;
                    fatPercent = 0.0d;
                    break;
                case "Buns":
                    waterPercent = 66.0d;
                    yeastPercent = 2.0d;
                    saltPercent = 1.5d;
                    sugarPercent = 2.5d;
                    fatPercent = 5.0d;
                    break;
                case "Pizza":
                    waterPercent = 59.0d;
                    yeastPercent = 1.25d;
                    saltPercent = 2.0d;
                    sugarPercent = 0.0d;
                    fatPercent = 0.0d;
                    break;
                default:
                    waterPercent = 65.0d;
                    yeastPercent = 1.2d;
                    saltPercent = 2.0d;
                    sugarPercent = 2.0d;
                    fatPercent = 2.0d;
                    break;
            }

            CalculateIngredients();

        }

        public virtual void CalculateIngredients() //function for Baker's Percentage calculations
        {
            //flour weight is naturally 100% of itself, but need to know sum of percentages to figure out how much flour it equates to
            double TotalPercent = 1.0 + (waterPercent + yeastPercent + saltPercent + sugarPercent + fatPercent) / 100;
            flourAmount = Math.Ceiling((double)mass / TotalPercent);        //deetermine flour amount, then calculate other ingredients
            waterAmount = Math.Ceiling(flourAmount * (waterPercent / 100)); //essentially the hydration level or ratio to flour
            yeastAmount = Math.Ceiling(flourAmount * (yeastPercent / 100)); //yeast ratio to flour
            saltAmount = Math.Ceiling(flourAmount * (saltPercent / 100));   //salt ratio to flour
            sugarAmount = Math.Ceiling(flourAmount * (sugarPercent / 100)); //sugar ratio to flour, not always used
            fatAmount = Math.Ceiling(flourAmount * (fatPercent / 100));     //oil, butter or shortening ratio to flour, not always used
        }
    }
}
