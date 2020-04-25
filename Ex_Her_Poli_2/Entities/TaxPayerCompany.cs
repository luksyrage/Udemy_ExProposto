namespace Ex_Her_Poli_2.Entities
{
    class TaxPayerCompany : TaxPayer
    {
        public int NumberEmployee { get; set; }

        public TaxPayerCompany()
        {
        }

        public TaxPayerCompany(int numberEmployee, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumberEmployee = numberEmployee;
        }

        public override double Taxes()
        {
            if (NumberEmployee > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
