using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{



    class Components
    {
        private string componentName;
        private string componentDetails;
        private decimal componentPrice;
        private string componentType;
        private string[] arrayComponentTypes = { "motherboard", "ram", "cpu", "grapich card", "hdd" };


        public Components(string componentName, decimal componentPrice, string type, string componentDetails)
        {
            this.Name = componentName;
            this.Price = componentPrice;
            this.Details = componentDetails;
            this.ComponentType = type;
        }
        public Components(string componentName, decimal componentPrice, string type)
            : this(componentName, componentPrice, type, null)
        {
        }
        public string ComponentType
        {
            get
            {
                return this.componentType;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Component cannot be empty or null", "Component Type");
                }
                bool check = false;
                foreach (string x in arrayComponentTypes)
                {
                    if (x.Equals(value.ToLower()))
                        check = true;
                }
                if (!check) { throw new ArgumentException("Invalid Component", "Component Type"); }
                this.componentType = value;
            }
        }
        public string Name
        {
            get { return this.componentName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be emtpy", "ComponentName");
                }
                this.componentName = value;
            }
        }
        public string Details
        {
            get { return this.componentDetails; }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Cannot be empty", "Component Details");
                }
                this.componentDetails = value;
            }
        }
        public decimal Price
        {
            get { return this.componentPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Component price cannot be negative", "Component Price");
                }
                this.componentPrice = value;
            }
        }


    }
}
