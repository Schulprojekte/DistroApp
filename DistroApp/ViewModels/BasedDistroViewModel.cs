/*
Autor: David Hülsberg, Daniel Rubcov
Datum: 21.12.2021
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
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "ArcoLinux", BasedDistroInfo = "ArcoLinux (früher bekannt als ArchMerge) ist eine auf Arch Linux basierende Distribution. ArcoLinux ist eine voll funktionsfähige Distribution, die mit dem Xfce-Desktop (sowie Openbox- und i3-Fenstermanagern) geliefert wird. ArcoLinux bietet auch verschiedene Video-Tutorials an, da es einen starken Fokus auf das Erlernen und Erwerben von Linux-Kenntnissen legt." });
                    break;

                case 2:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Ubuntu", BasedDistroInfo = "Ubuntu, auch Ubuntu Linux, ist eine Linux-Distribution, die auf Debian basiert. Der Name Ubuntu bedeutet auf Zulu etwa „Menschlichkeit“ und bezeichnet eine afrikanische Philosophie." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Linux Mint", BasedDistroInfo = "Linux Mint ist eine Linux-Distribution für PC in zwei parallel verfügbaren Ausgaben. Die Hauptausgabe, einfach Linux Mint genannt, basiert auf der Linux-Distribution Ubuntu und ist in drei Varianten verfügbar, nämlich als Cinnamon-, MATE- und Xfce-Edition." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "MX Linux", BasedDistroInfo = "MX Linux ist ein hinsichtlich des Ressourcenverbrauchs mittelschweres Linux-Betriebssystem, das auf der Distribution/Variante Debian/stable basiert und zentrale antiX-Komponenten verwendet. Zusätzliche Software wird von der MX-Gemeinschaft erstellt und/oder gepackt." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Deepin", BasedDistroInfo = "Deepin ist eine chinesische Linux-Distribution, die auf Debian basiert. Deepin ist die meistgenutzte chinesische Linux-Distribution. Die seit 2013 eigens entwickelte Desktop-Umgebung Deepin Desktop Environment basierte ursprünglich auf WebKit und HTML5, bis sie 2015 auf Qt 5 portiert wurde." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Kali Linux", BasedDistroInfo = "Kali Linux ist eine auf Debian basierende Linux-Distribution, die vor allem Programme für Penetrationstests und digitale Forensik umfasst. Kali Linux richtet sich in erster Linie an professionelle und fortgeschrittene Anwender. Kali besitzt die GNU-GPL-Lizenz und gilt demnach als Open Source." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Parrot OS", BasedDistroInfo = "Parrot OS ist eine auf Debian Testing basierende Linux-Distribution, die sich auf die Computersicherheit konzentriert. Sie ist für Penetrationstests, Schwachstellenbewertung und -minderung, Computerforensik und anonymes Web-Browsing konzipiert. Sie wird vom Frozenbox-Team entwickelt." });
                    break;

                case 3:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "SUSE", BasedDistroInfo = "SUSE Linux ist ein von SUSE entwickeltes Computer-Betriebssystem. Es basiert auf dem freien und Open-Source-Linux-Kernel und wird mit System- und Anwendungssoftware aus anderen Open-Source-Projekten vertrieben." });
                    break;

                case 4:
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Fedora", BasedDistroInfo = "Fedora ist eine RPM-basierte Linux-Distribution. Ziel der Entwickler der Distribution ist es, Freie Software zu fördern und ein Betriebssystem für eine möglichst vielfältige Zielgruppe zu gestalten." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "CentOS", BasedDistroInfo = "CentOS ist eine Linux-Distribution, die auf Red Hat Enterprise Linux des Unternehmens Red Hat aufbaut. Die Distribution wird von einer offenen Gruppe von freiwilligen Entwicklern betreut, gepflegt und weiterentwickelt." });
                    BasedDistroList.Add(new BasedDistros() { BasedDistroName = "Oracle Linux", BasedDistroInfo = "Oracle Linux ist eine Linux-Distribution, die von der Firma Oracle seit Ende 2006 gepackt und frei verteilt wird. Diese steht teilweise unter der GNU General Public License. Sie wurde aus der Red-Hat-Enterprise-Linux-Quelle zusammengestellt, wobei das Red Hat-Branding durch das von Oracle ersetzt wurde." });
                    break;

                default:

                    break;
            }

        }
    }
}