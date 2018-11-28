using Newtonsoft.Json;
using Restaurante.Dominio;
using System;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurante.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void Ingreso(object sender, EventArgs e)
        {
            var usuario = Usuario.Text;
            var password = Password.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                await DisplayAlert("Validacion", "Ingrese el Usuario", "Aceptar");
                Usuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Validacion", "Ingrese Password", "Aceptar");
                Password.Focus();
            }

            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://192.168.137.1");

            var Usuarios = new Usuarios
            {
                Usuario = usuario,
                Password = password
            };

            string json = JsonConvert.SerializeObject(Usuarios);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = await cliente.PostAsync("/Restaurante.Api/api/Login", content);
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var Permitido = JsonConvert.DeserializeObject<Validar>(responseJson);

                if (Permitido.Espermitido)
                {
                    await Navigation.PushAsync(new RestaurantesPage());
                }
                else
                {
                    await DisplayAlert("Mijo No Paso", Permitido.Mensaje, "Buena Suerte");
                }
            }
        }
    }
}