using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using resturant_app.models;

using Xamarin.Forms.Xaml;

namespace resturant_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class reservation : ContentPage
    {
        public reservation()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new add_reservation
            {
                BindingContext = new Notes()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new add_reservation
                {
                    BindingContext = e.SelectedItem as Notes
                });
            }
        }
    }
}