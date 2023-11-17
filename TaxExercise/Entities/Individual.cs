using System;

namespace TaxExercise.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; protected set; }

        //Construtores
        public Individual()
        {
        }

        public Individual(string name, double income, double expenditures) : base(name, income)
        {
            HealthExpenditures = expenditures;
        }

        //Sobreposição
        public override double Taxes()
        {
            double taxe = 0.0;
            if (AnnualIncome < 20000.00)
            {
                taxe = AnnualIncome * 0.15;
                if (HealthExpenditures > 0)
                {
                    return taxe -= HealthExpenditures * 0.50;
                }
                else
                {
                    return taxe;
                }
            }
            else
            {
                taxe += AnnualIncome * 0.25;
                if (HealthExpenditures > 0)
                {
                    return taxe -= HealthExpenditures * 0.50;
                }
                else
                {
                    return taxe;
                }
            }
        }
    }
}
