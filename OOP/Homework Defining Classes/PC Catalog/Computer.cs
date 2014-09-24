using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Computer
    {
        private string computerName;
        private List<Components> components = new List<Components>();

        public Computer(string computerName)
        {
            this.Name = computerName;

        }
        public Computer(string computerName, List<Components> components)
            : this(computerName)
        {
            this.Components = components;   

        }
        public string Name
        {
            get
            {
                return this.computerName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Computer name cannot be empty", "Computer Name");
                }
                this.computerName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.components.Sum(a => a.Price);
            }

        }

        public List<Components> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Computer components cannot be null", "Components");
                }
                this.components = value;
            }
        }
        public List<Components> SortByPrice(List<Components> component)
        {
            return component.OrderBy(x => x.Price).ToList();
        }
       
        public void PrintInfo()
        {
            decimal price = 0;
            components = SortByPrice(components);
            foreach (Components component in components)
            {
                price += component.Price;
            }
            string info = "Computer: " + Name + " -> Total Price : " + String.Format("{0:0.00}", price) + " lv\n";

            foreach (Components component in components)
            {
                info += "Component " + component.ComponentType.ToUpper() + ":" + component.Name + " -> Price: " + String.Format("{0:0.00}", component.Price);
                if (component.Details != null)
                {
                    info += " Details: " + component.Details + "\n";
                }
                else
                {
                    info += "\n";
                }

            }
            Console.WriteLine(info);
        }
    }
}
