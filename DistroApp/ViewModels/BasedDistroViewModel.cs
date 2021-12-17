/*
Autor: David Hülsberg
Datum: 28.11.2021
*/
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
            switch (Statisch1.BaseDistroID)
            {
                case 1:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 2, BasedDistroName = "EndavourOS", BasedDistroInfo = "EndavourOS info" });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 2, BasedDistroName = "BlackArch", BasedDistroInfo = "BlackArch info" });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 2, BasedDistroName = "Manjaro", BasedDistroInfo = "Manjaro info" });
                    break;

                case 2:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 1, BasedDistroName = "Ubuntu", BasedDistroInfo = "Ubuntu info" });
                    break;

                case 3:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 1, BasedDistroName = "SUSE", BasedDistroInfo = "SUSE info" });
                    break;

                case 4:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 3, BasedDistroName = "Fedora", BasedDistroInfo = "Fedora info" });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroID = 4, BasedDistroName = "CentOS", BasedDistroInfo = "CentOS info" });
                    break;

                default:

                    break;
            }

        }
    }
}