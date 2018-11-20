using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Restaurante.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapaPage : ContentPage
	{
		public MapaPage ()
		{
            InitializeComponent ();
           MyMap.MoveToRegion(
               MapSpan.FromCenterAndRadius(
                    new Position(6.208576, -75.567267),
                    Distance.FromMeters(150)

                    )
               );
           /* var map = new Map(MapSpan.FromCenterAndRadius(new Position(-75.567325, 6.20854),
                  Distance.FromMeters(200)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var MayThai = new Position(6.207954, -75.567588);
            var AlRojo = new Position(6.20874853, -75.56771308);
            var AyCaramba = new Position(6.20868187, -75.56743145);
            var PatriaMia = new Position(6.20870112, -75.5668575);

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = PatriaMia,
                Label = "Patria Mia",
            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = AlRojo,
                Label = "Al Rojo",
            };

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = AyCaramba,
                Label = "Ay Caramba",
            };

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = MayThai,
                Label = "May Thai",
            };*/
        }
	}
}