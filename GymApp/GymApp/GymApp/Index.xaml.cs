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
    public partial class Index : TabbedPage
    {
        public Index ()
        {
            InitializeComponent();
            Children.Add(new Informacion());
            Children.Add(new Rutina());
            Children.Add(new Pago());
            
        }
    }
}