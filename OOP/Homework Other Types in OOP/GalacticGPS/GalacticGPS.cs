using System;

namespace GalacticGPS
{
    internal class GalacticGps
    {
        private static void Main(string[] args)
        {
            var home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}