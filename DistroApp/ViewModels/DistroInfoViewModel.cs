/*
Autor: David Hülsberg, Daniel Rubcov
Datum: 21.12.2021
*/
namespace DistroApp
{
    public class DistroInfoViewModel
    {

        //Deklariert Getter und Setter, damit in "DistroInfoView" ein Binding erstellt werden kann.
        public string AnzeigeDistroName { get; set; }
        public string AnzeigeDistroInfo { get; set; }

        public DistroInfoViewModel()
        {
            //Holt die Werte aus "Statisch2" und weist diese zu.
            AnzeigeDistroName = Statisch2.BasedDistroName;
            AnzeigeDistroInfo = Statisch2.BasedDistroInfo;
        }
    }
}