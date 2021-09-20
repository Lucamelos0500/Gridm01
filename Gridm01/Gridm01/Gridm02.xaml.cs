using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gridm01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gridm02 : ContentPage
    {
        public Gridm02()
        {
            InitializeComponent();
        }

        private void btVoltar(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}