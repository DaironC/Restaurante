using Newtonsoft.Json;
using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Restaurante.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallesPage : ContentPage
	{
        private Informacion informacion;

 

        public DetallesPage(Informacion informacion)
        {
            InitializeComponent();
            this.informacion = informacion;
            BindingContext = informacion;

            CargarMapa();
        }

       

      

        private void CargarMapa()
        {
            MyMap.MoveToRegion(
              MapSpan.FromCenterAndRadius(
                   new Position(6.208576, -75.567267),
                   Distance.FromMeters(1500)));


            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.20870112, -75.5668575),
                Label = "Patria Mia",
                Address = "Comida Colombiana",
            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.20874853, -75.56771308),
                Label = "Al Rojo",
                Address = "Comida Italiana",
            };

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.207954, -75.567588),
                Label = "Ay Caramba",
                Address = "Comida Mexicana",
            };

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.20868187, -75.56743145),
                Label = "May Thai",
                Address = "Comida Tailandesa",
            };  

            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.242556, -75.593028),
                Label = "Kusi",
                Address = "Comida Peruana",
            };

            MyMap.Pins.Add(pin1);
            MyMap.Pins.Add(pin2);
            MyMap.Pins.Add(pin3);
            MyMap.Pins.Add(pin4);
            MyMap.Pins.Add(pin5);
        }

    }
}