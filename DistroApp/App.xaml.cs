/*
Autor: David Hülsberg, Daniel Rubcov
Datum: 21.12.2021
*/
using Xamarin.Forms;

namespace DistroApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Öffnet die Seite "BasedDistroView".
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
