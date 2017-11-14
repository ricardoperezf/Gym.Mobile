using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Rutina : ContentPage
	{
		public Rutina ()
		{
			InitializeComponent ();
            btnRutina1.Clicked += BtnRutina1_Clicked;
            btnRutina2.Clicked += BtnRutina2_Clicked;
            btnRutina3.Clicked += BtnRutina3_Clicked;
		}
        private void BtnRutina1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumeroRutina(1));
        }

        private void BtnRutina2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumeroRutina(2));
        }

        private void BtnRutina3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumeroRutina(3));
        }

        

        
    }
}