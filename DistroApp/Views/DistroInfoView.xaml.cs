using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DistroApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DistroInfoView : ContentPage
    {
        public DistroInfoView()
        {
            DistroInfoViewModel.setDistroInfo(Statisch2.BasedDistroID, Statisch2.BasedDistroName, Statisch2.BasedDistroInfo);
            InitializeComponent();
        }
    }
}