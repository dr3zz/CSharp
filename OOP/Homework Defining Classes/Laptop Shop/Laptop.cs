using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{



    public class Laptop
    {

        private string manufacturer;
        private string model;
        private string processor;
        private string graphicCard;
        private double price;
        private string screen;
        private string ram;
        private string hdd;


        private Battery battery = new Battery();
        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, string ram, string graphicCard, string hdd, string screen, string battery,double batteryLife = 0, double price = 0)
        {
            this.Battery.BatteryType = battery;
            this.Battery.BatteryLife = batteryLife;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Processor = processor;
            this.Screen = screen;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Ram = ram;
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Model cannot be empty or null");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Manufacturer cannot be empty or null");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Processor cannot be empty or null");
                }
                this.processor = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("HDD cannot be empty or null");
                }
                this.hdd = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Ram cannot be empty or null");
                }
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Graphic Card cannot be empty or null");
                }
                this.graphicCard = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {

                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Screen cannot be empty or null");
                }
                this.screen = value;
            }
        }


        public override string ToString()
        {
            string info = "Sample laptop description :\n";

            if (Model != null) info += "model: " + Model + "\n";
            if (Manufacturer != null) info += "manufacturer: " + Manufacturer + "\n";
            if (Processor != null) info += "processor: " + Processor + "\n";
            if (Ram != null) info += "RAM: " + Ram + "\n";
            if (GraphicCard != null) info += "graphics card: " + GraphicCard + "\n";
            if (HDD != null) info += "HDD: " + HDD + "\n";
            if (Screen != null) info += "screen: " + Screen + "\"\n";
            if (battery.BatteryType != null) info += "battery: " + battery.BatteryType + "\n";
            if (battery.BatteryLife != 0) info += "battery life: " + battery.BatteryLife + " hours \n";
            if (Price != 0) info += "Laptop price: " + String.Format("{0:0.00}", Price) + " lv\n";
            return info;
        }

    }
}
