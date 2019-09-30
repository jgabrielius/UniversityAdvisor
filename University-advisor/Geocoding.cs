using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Globalization;
using University_advisor.Models;
using University_advisor.Forms;
using Newtonsoft.Json;

namespace University_advisor
{
    class Geocoding
    {
        string LocationIqApiKey = "5e66cc9d64db23";
        public (double, double) GetCoordinates(string url)
        {
            var jsonRes = new ApiCalls().GetLocationJson(url);
            var locationData = JsonConvert.DeserializeObject<List<LocationData>>(jsonRes);
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
            text = text.Replace(" ", "%20");
            return text;
        }
        public (List<UniversityInfo>, double, double) ShowSchoolsInRange(int range, string address)
        {
            string userAddress = ConstructApiUrl(address);
            var userCoordinates = GetCoordinates(userAddress);
            string sqlGetSchoolName = "SELECT name FROM universities";
            string sqlGetSchoolLatitude = "SELECT latitude FROM universities";
            string sqlGetSchoolLongitude = "SELECT longitude FROM universities";
            ArrayList schoolNamesObj = SqlDriver.Fetch(sqlGetSchoolName);
            ArrayList schoolLatitudeObj = SqlDriver.Fetch(sqlGetSchoolLatitude);
            ArrayList schoolLongitudeObj = SqlDriver.Fetch(sqlGetSchoolLongitude);
            List<double> distanceBetween = new List<double>();
            List<string> schoolNames = new List<string>();
            var schoolsInRange = new List<UniversityInfo>();
            var schoolsInRangeNames = new List<string>();
            var schoolCoordinates = new List<(double, double)>();

            for (int i = 0; i < schoolNamesObj.Count; i++) {
                string name = ((Dictionary<string, object>)schoolNamesObj[i])["name"].ToString();
                string lat = ((Dictionary<string, object>)schoolLatitudeObj[i])["latitude"].ToString();
                string lon = ((Dictionary<string, object>)schoolLongitudeObj[i])["longitude"].ToString();

                schoolNames.Add(name);
                schoolCoordinates.Add((Convert.ToDouble(lat), Convert.ToDouble(lon)));
                distanceBetween.Add(GetDistance(userCoordinates.Item1, userCoordinates.Item2, Convert.ToDouble(lat), Convert.ToDouble(lon)));

                if ((int)distanceBetween[i] <= range * 1000)
                {
                    var newUniInfo = new UniversityInfo(Convert.ToDouble(lat), Convert.ToDouble(lon), schoolNames[i]);
                    schoolsInRange.Add(newUniInfo);
                }
            }
            return (schoolsInRange, userCoordinates.Item1, userCoordinates.Item2);
        }
    }
    public class UniversityInfo
    {
        public double latitude;
        public double longitude;
        public string name;

        public UniversityInfo(double lat, double lon, string name) {
            this.latitude = lat;
            this.longitude = lon;
            this.name = name;
        }
    }
}
