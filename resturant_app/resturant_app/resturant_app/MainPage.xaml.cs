using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace resturant_app
{
    public partial class MainPage :TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        private async void Food_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tst_food_menu());
        }
        private async void Drinks_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new food_page());
        }
        private async void map_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new map_page());
        }
    }
}
