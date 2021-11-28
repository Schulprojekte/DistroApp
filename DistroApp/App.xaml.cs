using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DistroApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BaseDistroView();
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
