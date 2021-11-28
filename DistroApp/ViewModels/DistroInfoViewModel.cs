/*
Autor: David Hülsberg
Datum: 28.11.2021
*/
namespace DistroApp
{
    public class DistroInfoViewModel
    {

        //Deklariert Getter und Setter, damit in "DistroInfoView" ein Binding erstellt werden kann. 
        public int AnzeigeDistroID { get; set; }
        public string AnzeigeDistroName { get; set; }
        public string AnzeigeDistroInfo { get; set; }

        public DistroInfoViewModel()
        {
            //Holt die Werte aus "Statisch2" und weist diese zu.
            AnzeigeDistroID = Statisch2.BasedDistroID;
            AnzeigeDistroName = Statisch2.BasedDistroName;
            AnzeigeDistroInfo = Statisch2.BasedDistroInfo;
        }
    }
}