using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using RestSharp;
using resturant_app.Models;

namespace resturant_app
{
    public partial class MainPage :TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Norris quotes;
            
            var client = new RestClient("https://api.chucknorris.io/jokes/random");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);
            quotes = JsonConvert.DeserializeObject<Norris>(response.Content);

            QuoteListView.BindingContext = quotes;
            QuoteListView.SetBinding(Label.TextProperty, quotes.ToString());
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
        private async void Reservation_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new reservation());
        }
    }
}
