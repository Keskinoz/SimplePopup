using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimplePopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<string> items = new List<string> { "Xamarin.Forms", "Xamarin.iOS", "Xamarin.Android", "Xamarin Monkeys" };

            imgMonkey.Source = ImageSource.FromResource("XamarinCustomPopup.images.monkey-MVP.png");

            imgPopup.Source = ImageSource.FromResource("XamarinCustomPopup.images.xammonkey.png");

            sampleList.ItemsSource = items;
        }

        private void btnPopupButton_Clicked(object sender, EventArgs e)

        {
            name.Text = "";
            address.Text = "";
            note.Text = "";
            popupLoginView.IsVisible = true;

            //activityIndicator.IsRunning = true;



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            popupLoginView.IsVisible = false;
            Console.WriteLine(name.Text+" "+address.Text);
        }
    }
}
