using System.Collections.ObjectModel;

namespace DistroApp
{
    class BasedDistroViewModel
    {
        //Deklariert Getter und Setter, damit in "BasedDistroView" ein Binding für die Liste erstellt werden kann. 
        public ObservableCollection<BasedDistros> BasedDistroList { get; set; }

        public BasedDistroViewModel()
        {
            //Erstellt die Liste "BasedDistroList" anhand vom "BasedDistros"-Model.
            BasedDistroList = new ObservableCollection<BasedDistros>();

            //Befüllt die Liste "BasedDistroList" basierend auf der Auswahl des Users.
            if (Statisch1.BaseDistroID == 1)
            {
                BasedDistroList.Add(new BasedDistros() { BasedDistroID = 2, BasedDistroName = "EndavourOS", BasedDistroInfo = "EndavourOS info" });
            }
            else if (Statisch1.BaseDistroID == 2)
            {
                BasedDistroList.Add(new BasedDistros() { BasedDistroID = 1, BasedDistroName = "Ubuntu", BasedDistroInfo = "Ubuntu info" });
            }

        }
    }
}