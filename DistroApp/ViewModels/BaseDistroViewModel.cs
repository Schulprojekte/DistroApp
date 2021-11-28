using System.Collections.ObjectModel;

namespace DistroApp
{
    public class BaseDistroViewModel
    {
        public ObservableCollection<BaseDistros> BaseDistroList { get; set; }

        public BaseDistroViewModel()
        {
            BaseDistroList = new ObservableCollection<BaseDistros>();
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 1, BaseDistroName = "Arch" });
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 2, BaseDistroName = "Debian" });
        }
    }
}