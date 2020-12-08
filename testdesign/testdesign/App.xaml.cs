using System;
using testdesign.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testdesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Profile();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
