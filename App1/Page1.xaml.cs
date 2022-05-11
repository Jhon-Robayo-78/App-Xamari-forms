using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (TXTusername.Text=="admin" && TXTpassword.Text=="123")
            {
                
                await Navigation.PushAsync(new HomePage(TXTusername.Text));
            }
            else {
               await DisplayAlert("Ops...", "Usuario o contraseña incorrecto", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}