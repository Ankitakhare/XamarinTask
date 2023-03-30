using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
    public partial class App : Xamarin.Forms.Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new Xamarin.Forms.NavigationPage(new LoginUI());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

