namespace Ex_Her_Poli_2.Entities
{
    class TaxPayerIndividual : TaxPayer
    {
        public double Health { get; set; }

        public TaxPayerIndividual() {
        }

        public TaxPayerIndividual(double health, string name, double anualIncome)
            : base(name, anualIncome)
        {
            Health = health;
        }

        public override double Taxes()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (Health * 0.50);
            } else {
                return (AnualIncome * 0.25) - (Health * 0.50);
            }
             
        }
    }
}
