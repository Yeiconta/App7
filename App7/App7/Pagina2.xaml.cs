using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
            this.lbOpcion.Text = string.Empty;
            Btn3.Clicked += Btn3_Clicked;
            BtnTest.Clicked += Btn3_Clicked;
        }
        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            var resp = await DisplayAlert("Test", "esta seguro de realizar el test", "si", "no");
            if (resp)
            {
                await DisplayAlert("inicio del test", "bienvenido", "aceptar");
                var option = await DisplayActionSheet("opcione", "cancelar", null, "opcion1", "opcion2", "opcion3");

                lbOpcion.Text = option.ToString();
            }
            else
            {
                await DisplayAlert("test falliudo", "en otra ocasion seraa", "aceptar");
            }
        }
        private async void Btn3(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Pagina3());
        }
    }
}