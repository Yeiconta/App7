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
	public partial class DemoNavigationPage : ContentPage
	{
		public DemoNavigationPage ()
		{
			InitializeComponent ();
		}
        private async void SiguienteButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pagina2());
        }
    }
}