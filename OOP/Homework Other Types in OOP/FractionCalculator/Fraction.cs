namespace FractionCalculator
{
    using System;
    using System.Numerics;

    public struct Fraction
    {
        private BigInteger numenator;
        private BigInteger denominator;

        public Fraction(BigInteger numenator, BigInteger denominator)
            : this()
        {
            this.Denominator = denominator;
            this.Numerator = numenator;
        }

        public BigInteger Numerator
        {
            get
            {
                return this.numenator;
            }

            set
            {
                if ((value < -9223372036854775808) || (value > 9223372036854775807))
                {
                    throw new ArgumentOutOfRangeException("Numerator is out of rage [-9223372036854775808...9223372036854775807]", "Fraction struct");
                }

                this.numenator = value;
            }
        }

        public BigInteger Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if ((value < -9223372036854775808) || (value > 9223372036854775807))
                {
                    throw new ArgumentOutOfRangeException("Denominator is out of rage [-9223372036854775808...9223372036854775807]", "Fraction struct");
                }

                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0", "Fraction struct");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            BigInteger num = (f1.numenator * f2.denominator) + (f2.numenator * f1.denominator);
            BigInteger denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            BigInteger num = (f1.numenator * f2.denominator) - (f2.numenator * f1.denominator);
            BigInteger denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            decimal numeratorDecilam = (decimal)this.Numerator;
            decimal denominatorDecimal = (decimal)this.Denominator;
            decimal result = numeratorDecilam / denominatorDecimal;
            return result.ToString();
        }
    }
}
