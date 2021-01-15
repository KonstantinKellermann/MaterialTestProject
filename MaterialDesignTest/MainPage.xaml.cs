using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaterialDesignTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaterialTestPage());
        }
    }
}
