using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DistroApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasedDistroView : ContentPage
    {
        public BasedDistroView()
        {
            BasedDistroViewModel.setBaseDistroID(Statisch1.BaseDistroID);
            InitializeComponent();
        }

        private void ListView2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            if (sender is ListView lv) lv.SelectedItem = null;
            var tappedItem = e.Item as BasedDistros;
            Statisch2.BasedDistroID = tappedItem.BasedDistroID;
            Statisch2.BasedDistroName = tappedItem.BasedDistroName;
            Statisch2.BasedDistroInfo = tappedItem.BasedDistroInfo;
            Navigation.PushModalAsync(new DistroInfoView());
        }
    }
}