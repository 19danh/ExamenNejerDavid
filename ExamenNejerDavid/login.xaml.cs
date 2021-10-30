using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenNejerDavid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenando en varibales lo que usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                //Permite abrir la ventana(ViewDos)
                await Navigation.PushAsync(new registro(usuario, clave));
                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new registro(usuario, clave));
                }
                else
                {
                    await DisplayAlert("Error", "Usuario/clave incorrectos", "oK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }

        private void btnAbrir_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}