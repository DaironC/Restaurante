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
			InitializeComponent ();
            this.informacion = informacion;
            BindingContext = listaDetalle;

            MyMap.MoveToRegion(
              MapSpan.FromCenterAndRadius(
                   new Position(6.208576, -75.567267),
                   Distance.FromMeters(150)
                   )
              );
        }

    }
}