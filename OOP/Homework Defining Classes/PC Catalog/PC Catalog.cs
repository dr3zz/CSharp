using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {

            Components motherboard = new Components("FOXCONND42S,INTEL NM10 CHIPSET", 55.20M, "motherboard");
            Components hdd = new Components("250 GB", 45.23M, "hdd");
            Components ram = new Components("16 GB", 120.32M, "ram", "Ram");
            Components processor = new Components("INTEL ATOM D425 1.8 GHz", 50.43M, "cpu");
            Computer computerOne = new Computer("Asus", new List<Components>() { motherboard, hdd, ram, processor });
            Computer computerTwo = new Computer("Asus");
           computerOne.PrintInfo();
            computerTwo.PrintInfo();

        }
    }
}
