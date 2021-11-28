/*
Autor: David Hülsberg
Datum: 28.11.2021
*/
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DistroApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasedDistroView : ContentPage
    {
        public BasedDistroView()
        {
            InitializeComponent();
        }


        //Methode wird ausgeführt, wenn ein Punkt im Menü "BasedDistros" angeklickt wird.
        private void ListView2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Sorgt dafür, dass Menüpunkte nicht mehr mit dem orangenem Hintergrund hinterlegt werden. 
            if (e.Item == null) return;
            if (sender is ListView lv) lv.SelectedItem = null;

            //Setzt den ausgewählten Menüpunkt in die Variable "tappedItem".
            var tappedItem = e.Item as BasedDistros;

            //Speichert ID, Name und Info des ausgewählten Menüpunktes in "Statisch2".
            Statisch2.BasedDistroID = tappedItem.BasedDistroID;
            Statisch2.BasedDistroName = tappedItem.BasedDistroName;
            Statisch2.BasedDistroInfo = tappedItem.BasedDistroInfo;

            //Öffnet die Seite "DistroInfoView".
            Navigation.PushModalAsync(new DistroInfoView());
        }
    }
}