using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resturant_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tst_contact : ContentPage
    {
        public tst_contact()
        {
            InitializeComponent();
        }
        private async void map_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new map_page());
        }
    }
}