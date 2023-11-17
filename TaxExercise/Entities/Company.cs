using System;

namespace TaxExercise.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; protected set; }

        //Construtores
        public Company()
        {
        }

        public Company(string name, double income, int numEmp) : base(name, income)
        {
            NumberEmployees = numEmp;
        }

        //Sobreposição
        public override double Taxes()
        {
            double taxe = 0.00;
            if (NumberEmployees > 10)
            {
                return taxe = AnnualIncome * 0.14;
            }
            else
            {
                return taxe = AnnualIncome * 0.16;
            }
        }
    }
}
