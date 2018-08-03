using LuckyPOC.Entities;
using LuckyPOC.RestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace LuckyPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            var map = LoadMap();

            LoadMarkers(map);
        }

        public Map LoadMap()
        {
            var map = new Map(MapSpan.FromCenterAndRadius(
                new Position(-23.6271, -46.7009), Distance.FromMiles(0.5)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

            return map;
        }

        public void LoadMarkers(Map mymap)
        {
            var list = AnimalRestOps.GetLostAnimals();

            foreach(Animal item in list)
            {
                var position = new Position(item.Latitude, item.Longitude); // Latitude, Longitude
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position,
                    Label = item.Description,
                    Address = item.Type.ToString()
                };
                mymap.Pins.Add(pin);
            }
        }
    }
}