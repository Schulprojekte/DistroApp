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

        private void ListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            if (sender is ListView lv) lv.SelectedItem = null;
            var tappedItem = e.Item as BaseDistros;
            Statisch1.BaseDistroID = tappedItem.BaseDistroID;
            Statisch1.BaseDistroName = tappedItem.BaseDistroName;
            Navigation.PushModalAsync(new BasedDistroView());
        }
    }
}