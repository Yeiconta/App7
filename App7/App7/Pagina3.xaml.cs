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
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{

			InitializeComponent ();
            this.btnInicial.Clicked += btnInicial_Clicked;
            this.BtnModal.Clicked += BtnModal_Clicked;
            this.BtnAtras.Clicked += BtnAtras_Clicked;
        }
        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PopAsync();
        }
        private async void BtnModal_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new Pagina4());
        }
        private async void btnInicial_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopToRootAsync();
        }
    }
}