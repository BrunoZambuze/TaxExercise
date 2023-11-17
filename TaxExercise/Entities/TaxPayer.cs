using System;

namespace TaxExercise.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; protected set; }
        public double AnnualIncome { get; set; }

        //Construtores
        public TaxPayer()
        {
        }

        public TaxPayer(string name, double income)
        {
            Name = name;
            AnnualIncome = income;
        }

        //"Sobreposição"
        public abstract double Taxes();
    }
}
