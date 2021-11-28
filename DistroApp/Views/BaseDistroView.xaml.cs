/*
Autor: David Hülsberg
Datum: 28.11.2021
*/
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DistroApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseDistroView : ContentPage
    {
        public BaseDistroView()
        {
            InitializeComponent();
        }

        //Methode wird ausgeführt, wenn ein Punkt im Menü "BaseDistros" angeklickt wird.
        private void ListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Sorgt dafür, dass Menüpunkte nicht mehr mit dem orangenem Hintergrund hinterlegt werden. 
            if (e.Item == null) return;
            if (sender is ListView lv) lv.SelectedItem = null;

            //Setzt den ausgewählten Menüpunkt in die Variable "tappedItem".
            var tappedItem = e.Item as BaseDistros;

            //Speichert ID und Name des ausgewählten Menüpunktes in "Statisch1".
            Statisch1.BaseDistroID = tappedItem.BaseDistroID;
            Statisch1.BaseDistroName = tappedItem.BaseDistroName;

            //Öffnet die Seite "BasedDistroView".
            Navigation.PushModalAsync(new BasedDistroView());
        }
    }
}