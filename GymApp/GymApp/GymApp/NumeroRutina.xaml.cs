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
    public partial class NumeroRutina : ContentPage
    {
        public NumeroRutina(int numRutina)
        {
            InitializeComponent();
            NombreRutina.Text = "Aquí esta la rutina " + numRutina;
        }
    }
}