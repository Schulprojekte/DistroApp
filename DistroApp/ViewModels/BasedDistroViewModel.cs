using System.Collections.ObjectModel;

namespace DistroApp
{
    class BasedDistroViewModel
    {

        static int baseDistID = 0;

        public ObservableCollection<BasedDistros> BasedDistroList { get; set; }

        public BasedDistroViewModel()
        {
            BasedDistroList = new ObservableCollection<BasedDistros>();
            if (baseDistID == 1)
            {
                BasedDistroList.Add(new BasedDistros() { BasedDistroID = 2, BasedDistroName = "EndavourOS", BasedDistroInfo = "EndavourOS info" });
            }
            else if (baseDistID == 2)
            {
                BasedDistroList.Add(new BasedDistros() { BasedDistroID = 1, BasedDistroName = "Ubuntu", BasedDistroInfo = "Ubuntu info" });
            }

        }

        internal static void setBaseDistroID(int baseDistroID)
        {

            if (baseDistroID == 1)
            {
                baseDistID = 1;
            }
            else if (baseDistroID == 2)
            {
                baseDistID = 2;
            }
        }
    }
}
