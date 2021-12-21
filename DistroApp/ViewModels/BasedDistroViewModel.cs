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
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "EndavourOS", BasedDistroInfo = "EndeavourOS wurde als Nachfolger von Antergos gegründet und ist eine auf Arch Linux basierende Linux-Distribution, die in der Offline-Installation mit der Xfce Desktop-Umgebung ausgeliefert wird." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "BlackArch", BasedDistroInfo = "BlackArch ist eine junge Linux-Distribution, die ihren Schwerpunkt auf Penetration legt. BlackArch ist eine spezialisierte Version von Arch Linux und dessen Derivat. Es wird verwendet, um Systeme zu härten und Sicherheitslücken zu reduzieren." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Manjaro", BasedDistroInfo = "Manjaro ist eine auf Arch Linux basierende Linux-Distribution, die in Österreich, Frankreich und Deutschland entwickelt wird. Es ist in erster Linie ein freies Betriebssystem für Personal Computer, welches auf Benutzerfreundlichkeit ausgerichtet ist. Wie seine Basis, Arch Linux, nutzt es ein Rolling-Release-Modell." });
                    break;

                case 2:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Ubuntu", BasedDistroInfo = "Ubuntu, auch Ubuntu Linux, ist eine Linux-Distribution, die auf Debian basiert. Der Name Ubuntu bedeutet auf Zulu etwa „Menschlichkeit“ und bezeichnet eine afrikanische Philosophie." });
                    break;

                case 3:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "SUSE", BasedDistroInfo = "SUSE Linux ist ein von SUSE entwickeltes Computer-Betriebssystem. Es basiert auf dem freien und Open-Source-Linux-Kernel und wird mit System- und Anwendungssoftware aus anderen Open-Source-Projekten vertrieben." });
                    break;

                case 4:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Fedora", BasedDistroInfo = "Fedora ist eine RPM-basierte Linux-Distribution. Ziel der Entwickler der Distribution ist es, Freie Software zu fördern und ein Betriebssystem für eine möglichst vielfältige Zielgruppe zu gestalten." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "CentOS", BasedDistroInfo = "CentOS ist eine Linux-Distribution, die auf Red Hat Enterprise Linux des Unternehmens Red Hat aufbaut. Die Distribution wird von einer offenen Gruppe von freiwilligen Entwicklern betreut, gepflegt und weiterentwickelt." });
                    break;

                default:

                    break;
            }

        }
    }
}