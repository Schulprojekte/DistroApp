﻿/*
Autor: David Hülsberg, Daniel Rubcov
Datum: 21.12.2021
*/
using System.Collections.ObjectModel;

namespace DistroApp
{
    public class BaseDistroViewModel
    {
        //Deklariert Getter und Setter, damit in "BaseDistroView" ein Binding für die Liste erstellt werden kann. 
        public ObservableCollection<BaseDistros> BaseDistroList { get; set; }

        public BaseDistroViewModel()
        {
            //Erstellt die Liste "BaseDistroList" anhand vom "BaseDistros"-Model.
            BaseDistroList = new ObservableCollection<BaseDistros>();

            //Befüllt die Liste "BaseDistroList".
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 1, BaseDistroName = "Arch" });
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 2, BaseDistroName = "Debian" });
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 3, BaseDistroName = "Slackware" });
            BaseDistroList.Add(new BaseDistros() { BaseDistroID = 4, BaseDistroName = "RedHat" });
        }
    }
}