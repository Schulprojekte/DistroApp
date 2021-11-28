namespace DistroApp
{
    public class DistroInfoViewModel
    {
        static int basedDistID = 0;
        static string basedDistName = null;
        static string basedDistInfo = null;
        public int AnzeigeDistroID { get; set; }
        public string AnzeigeDistroName { get; set; }
        public string AnzeigeDistroInfo { get; set; }

        public DistroInfoViewModel()
        {
            AnzeigeDistroID = basedDistID;
            AnzeigeDistroName = basedDistName;
            AnzeigeDistroInfo = basedDistInfo;
        }

        internal static void setDistroInfo(int basedDistroID, string basedDistroName, string basedDistroInfo)
        {
            basedDistID = basedDistroID;
            basedDistName = basedDistroName;
            basedDistInfo = basedDistroInfo;
        }
    }
}