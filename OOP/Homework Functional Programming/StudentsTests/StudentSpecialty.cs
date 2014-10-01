namespace StudentsTests
{
    using System;

    class StudentSpecialty
    {
        private string specialtyName;

        private int facNum;

        public StudentSpecialty(string specialtyName, int facNum)
        {
            this.SpecialtyName = specialtyName;
            this.FacNum = facNum;
        }

        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Specialty name cannot be empry");
                }

                this.specialtyName = value;
            }
        }

        public int FacNum
        {
            get
            {
                return this.facNum;
            }

            set
            {
                if ((value < 80000000) || (value > 89999999))
                {
                    throw new ArgumentOutOfRangeException("faculty Number is out of range [80000000..89999999]");
                }

                this.facNum = value;
            }
        }
    }
}
