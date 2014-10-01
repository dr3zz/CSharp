namespace InterestCalculator
{
    using System;

    class InterestCalculator
    {
        private decimal money;
        private double percent;
        private int years;
        private string type;
        private decimal payBackMoney;

        public InterestCalculator(decimal money, double interest, int years, string type)
        {
            this.Money = money;
            this.Percent = interest;
            this.Years = years;
            this.Type = type;
            if (this.Type.ToLower() == "simple")
            {
                this.payBackMoney = GetSimpleInterest(money, interest, years);
            }
            else if (this.Type.ToLower() == "compound")
            {
                this.payBackMoney = GetCompoundInterest(money, interest, years);
            }
            else
            {
                this.payBackMoney = 0;
            }
        }

        public delegate decimal CalculateInterest(decimal sum, double interest, int years);

        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public double Percent
        {
            get
            {
                return this.percent;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new IndexOutOfRangeException("Invalid input interest can be in rage [1..100]");
                }

                this.percent = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Years cannot be negative");
                }

                this.years = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input for interest calculation method cannot be empty or null");
                }

                this.type = value;
            }
        }

        public override string ToString()
        {
            if (this.payBackMoney == 0)
            {
                return "Invalid interest calculation type, can be only \"simple\" or \"compound\"";
            }

            string ret = string.Format("{0:F4}", this.payBackMoney);
            return ret;
        }

        private static decimal GetSimpleInterest(decimal sum, double interest, int years)
        {
            decimal percent = (decimal)interest / 100;
            decimal result = sum * (1 + (percent * years));
            return result;
        }

        private static decimal GetCompoundInterest(decimal sum, double interest, int years)
        {
            int n = 12;
            double percent = interest / 100;
            decimal compound = 1;
            for (int i = 0; i < years * n; i++)
            {
                compound *= (1 + ((decimal)percent / n));
            }

            decimal result = sum * compound;
            return result;
        }
    }
}
