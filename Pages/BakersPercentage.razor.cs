﻿using Microsoft.AspNetCore.Components;

namespace ePortfolio.Pages
{
    public partial class BakersPercentage
    {
        public int mass = 600;
        public string breadType = "";
        public float waterPercent = 63.0F;
        public float yeastPercent = 1.2F;
        public float saltPercent = 1.0F;
        public float sugarPercent = 3.5F;
        public float fatPercent = 8.0F;
        public float flourAmount = 0.0F;
        public float waterAmount = 0.0F;
        public float yeastAmount = 0.0F;
        public float saltAmount = 0.0F;
        public float sugarAmount = 0.0F;
        public float fatAmount = 0.0F;

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
                case "Sandwich":
                    waterPercent = 63.0F;
                    yeastPercent = 1.2F;
                    saltPercent = 1.0F;
                    sugarPercent = 3.5F;
                    fatPercent = 8.0F;
                    break;
                case "Focaccia":
                    waterPercent = 90.0F;
                    yeastPercent = .75F;
                    saltPercent = 3.5F;
                    sugarPercent = 0F;
                    fatPercent = 9.4F;
                    break;
                case "Ciabatta":
                    waterPercent = 82.0F;
                    yeastPercent = .4F;
                    saltPercent = 2.2F;
                    sugarPercent = 0F;
                    fatPercent = 0F;
                    break;
                case "French":
                    waterPercent = 66.0F;
                    yeastPercent = 1.25F;
                    saltPercent = 2.0F;
                    sugarPercent = 0F;
                    fatPercent = 0F;
                    break;
                case "Buns":
                    waterPercent = 66.0F;
                    yeastPercent = 2.0F;
                    saltPercent = 1.5F;
                    sugarPercent = 2.5F;
                    fatPercent = 5.0F;
                    break;
                case "Pizza":
                    waterPercent = 59.0F;
                    yeastPercent = 1.25F;
                    saltPercent = 2.0F;
                    sugarPercent = 0.0F;
                    fatPercent = 0.0F;
                    break;
                default:
                    waterPercent = 65.0F;
                    yeastPercent = 1.2F;
                    saltPercent = 2.0F;
                    sugarPercent = 2.0F;
                    fatPercent = 2.0F;
                    break;
            }

            CalculateIngredients();

        }

        public virtual void CalculateIngredients() //function for Baker's Percentage calculations
        {
            float TotalPercent = 1 + (waterPercent + yeastPercent + saltPercent) / 100;
            flourAmount = (mass / TotalPercent);
            waterAmount = flourAmount * (waterPercent / 100);
            yeastAmount = flourAmount * (yeastPercent / 100);
            saltAmount = flourAmount * (saltPercent / 100);
            sugarAmount = flourAmount * (sugarPercent / 100);
            fatAmount = flourAmount * (fatPercent / 100);
        }
    }
}

