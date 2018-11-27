using Newtonsoft.Json;
using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurante.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantesPage : ContentPage
    {
        private Informacion Informacion;

        public RestaurantesPage()
        {
            InitializeComponent();
            CargarRestaurantes();
        }

        private async void CargarRestaurantes()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://172.18.78.79");

            var request = await cliente.GetAsync("/Restaurante.Api/api/Informacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var restaurantes = JsonConvert.DeserializeObject<List<Informacion>>(responseJson);
                ListaRestaurantes.ItemsSource = restaurantes;
            }
            else
            {
                await DisplayAlert("Error", "Revisar IP de la API", "Buena Suerte Joven");
            }
        }

        private async void Restaurante_Selecionado(object sender,SelectedItemChangedEventArgs e)
        {
            var informacion = (Informacion)e.SelectedItem;
            await Navigation.PushAsync(new DetallesPage(informacion));
        }
    }
}