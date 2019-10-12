using System;
using System.Collections;
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
    class GeoLocation
    {
        string LocationIqApiKey = "5e66cc9d64db23";
        public (double, double) GetCoordinates(string url)
        {
            var jsonRes = new ApiCalls().GetLocationJson(url);
            var locationData = JsonConvert.DeserializeObject<List<LocationModel>>(jsonRes);
            var firstLocation = locationData[0];

            return (double.Parse(firstLocation.Lat, CultureInfo.InvariantCulture.NumberFormat), double.Parse(firstLocation.Lon, CultureInfo.InvariantCulture.NumberFormat));
        }
        public double GetDistance(double latA, double lonA, double latB, double lonB)
        {
            var locA = new GeoCoordinate(latA, lonA);
            var locB = new GeoCoordinate(latB, lonB);
            return locA.GetDistanceTo(locB);
        }
        public string ConstructApiUrl(string address)
        {
            string text = "https://eu1.locationiq.com/v1/search.php?key=" + LocationIqApiKey + "&q=" + address + "&format=json";
            return text.Replace(" ", "%20");
        }
        public List<MarkerModel> GetSchoolsInRangeMarkers(double range, MarkerModel user)
        {
            ArrayList schoolInfo = SqlDriver.Fetch("SELECT name,latitude,longitude FROM universities");
            var schoolsInRange = new List<MarkerModel>();

            foreach (var school in schoolInfo)
            {
                var name = ((Dictionary<string, object>)school)["name"].ToString();
                var lat = ((Dictionary<string, object>)school)["latitude"].ToString();
                var lon = ((Dictionary<string, object>)school)["longitude"].ToString();
                var distance = GetDistance(user.Latitude, user.Longitude, Convert.ToDouble(lat), Convert.ToDouble(lon));
                if (distance <= range * 1000)
                {
                    var newUniInfo = new MarkerModel
                    {
                        Latitude = Convert.ToDouble(lat),
                        Longitude = Convert.ToDouble(lon),
                        Name = name,
                        Type = 1
                    };
                    schoolsInRange.Add(newUniInfo);
                }
            }
            return (schoolsInRange);
        }
    }
}
