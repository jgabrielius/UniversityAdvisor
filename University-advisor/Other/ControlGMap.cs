using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_advisor.Models;
using University_advisor.Tools;
using University_advisor.Constants;
using GMap.NET;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace University_advisor
{
    class ControlGMap
    {
        GMapControl map;
        GMapOverlay markers;

        public ControlGMap(GMapControl gMap)
        {
            map = gMap;
            markers = new GMapOverlay("markers");
            map.Overlays.Add(markers);
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.ShowCenter = false;
            CenterMap(55.169437, 23.881275);
        }
        public void ClearMarkers()
        {
            markers.Markers.Clear();
        }
        public void AddMarker(GMapMarker marker)
        {
            markers.Markers.Add(marker);
        }
        public void CreateMarker(MarkerModel markerInfo)
        {
            GMapMarker newMarker;
            switch (markerInfo.Type)
            {
                case 1:
                    newMarker = new GMarkerGoogle(
                    new PointLatLng(markerInfo.Latitude, markerInfo.Longitude),
                    GMarkerGoogleType.green_small);
                    break;
                case 2:
                    newMarker = new GMarkerGoogle(
                    new PointLatLng(markerInfo.Latitude, markerInfo.Longitude),
                    GMarkerGoogleType.red_dot);
                    break;
                default:
                    newMarker = new GMarkerGoogle(
                    new PointLatLng(markerInfo.Latitude, markerInfo.Longitude),
                    GMarkerGoogleType.purple_small);
                    break;
            }
            newMarker.ToolTipText = markerInfo.Name;
            AddMarker(newMarker);
        }
        public void CenterMap(double lat, double lon)
        {
            map.Position = new PointLatLng(lat, lon);
        }
        public void UpdateMap(string range, string address, Label messageLabel)
        {
            ClearMarkers();
            try
            {
                if (double.TryParse(range, out double n) && address != "")
                {
                    var geoLocation = new GeoLocation();
                    var userCoordinates = geoLocation.GetCoordinates(geoLocation.ConstructApiUrl(address));
                    var userMarker = new MarkerModel
                    {
                        Latitude = userCoordinates.Item1,
                        Longitude = userCoordinates.Item2,
                        Name = "Your Location",
                        Type = 2
                    };
                    var schoolsInRange = geoLocation.GetSchoolsInRangeMarkers(Convert.ToDouble(range), userMarker);

                    CenterMap(userMarker.Latitude, userMarker.Longitude);
                    CreateMarker(userMarker);

                    foreach (var school in schoolsInRange) CreateMarker(school);

                    SetMessage(messageLabel, Messages.emptyString);
                }
                else
                {
                    SetMessage(messageLabel, Messages.incorrectInformation);
                }
            }
            catch (Exception e)
            {
                Logger.Log(e.Message);
            }
        }
        public void SetMessage(Label label, string message)
        {
            label.Text = message;
        }
    }
}
