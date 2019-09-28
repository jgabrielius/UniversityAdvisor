using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Globalization;
using University_advisor.Models;
using Newtonsoft.Json;

namespace University_advisor
{
    class Geocoding
    {
        string LocationIqApiKey = "5e66cc9d64db23";
        public double ReturnDistance(string urlA, string urlB)
        {
            var jsonA = new ApiCalls().GetLocationJson(urlA);
            var jsonB = new ApiCalls().GetLocationJson(urlB);

            var locationDataA = JsonConvert.DeserializeObject<List<LocationData>>(jsonA);
            var locationDataB = JsonConvert.DeserializeObject<List<LocationData>>(jsonB);

            var locationA = new Geocoding().GetCoordinates(locationDataA[0]);
            var locationB = new Geocoding().GetCoordinates(locationDataB[0]);

            var distance = new Geocoding().GetDistance(locationA.Item1, locationA.Item2, locationB.Item1, locationB.Item2);

            return distance;
        }

        public (double, double) GetCoordinates(LocationData address)
        {
            return (double.Parse(address.Lat, CultureInfo.InvariantCulture.NumberFormat), double.Parse(address.Lon, CultureInfo.InvariantCulture.NumberFormat));
        }

        public double GetDistance(double latA, double lonA, double latB, double lonB)
        {
            var locA = new GeoCoordinate(latA, lonA);
            var locB = new GeoCoordinate(latB, lonB);

            return locA.GetDistanceTo(locB);
        }
        public string ConstructApiUrl(string street, string city, string country) {
            return $"https://eu1.locationiq.com/v1/search.php?key={LocationIqApiKey}={street},{city},{country}&q=format=json";
        }
        public string ConstructApiUrl(string street, string city, string state, string country)
        {
            return $"https://eu1.locationiq.com/v1/search.php?key={LocationIqApiKey}={street},{city},{state},{country}&q=format=json";
        }
        public string ConstructApiUrl(string street, string city, string state, string country, string postalCode)
        {
            return $"https://eu1.locationiq.com/v1/search.php?key={LocationIqApiKey}={street},{city},{state},{country},{postalCode}&q=format=json";
        }
    }
}
