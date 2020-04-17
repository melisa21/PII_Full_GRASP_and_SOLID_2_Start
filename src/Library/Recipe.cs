//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }


        public double GetProductionCost()
        {
            double result = 0;
            foreach (Step item in this.steps)
            {
                result = result + item.StepCost();
            }
            return result;
        }

        public string GetTextToPrint()
        {
            string text = "";
            text += $"Receta de {this.FinalProduct.Description}: \n";
            foreach (Step step in this.steps)
            {
                text += $"{step.Quantity} de {step.Input.Description}" +
                $" usando {step.Equipment.Description} durante {step.Time} \n";
            }
            
            text += "\n Costo Total de produccion: "+this.GetProductionCost();
            return text;
    
        }
    }
}