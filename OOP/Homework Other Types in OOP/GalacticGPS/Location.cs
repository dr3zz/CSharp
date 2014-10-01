using System.Text;

namespace GalacticGPS
{
    public struct Location
    {
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            Latitude = latitude;
            Longitude = longitude;
            Planet = planet;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("{0}, {1} - {2}", Latitude, Longitude, Planet));
            return sb.ToString();
        }
    }
}