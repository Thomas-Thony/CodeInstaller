using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CodeInstaller.Classes;

namespace CodeInstaller.Classes
{
    public class Framework {
        private string nom;
        private decimal version;
        private string documentationGithub;
        private PackageManager pm;
        private List<string> lesVersions; // A implémenter plus tard...
        private string logo; // Changer le lien des logos qui ne répondent pas dans le json

        public Framework(string aNom, decimal uneVersion, string lienDocGithub, PackageManager aPm, string unLogo) {
            this.Nom = aNom;
            this.Version = uneVersion;
            this.DocumentationGithub = lienDocGithub;
            this.pm = aPm;
            this.logo = unLogo;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string DocumentationGithub { get => documentationGithub; set => documentationGithub = value; }
        public string Logo { get => logo; set => logo = value; }

        public void createProjectFromFramework() {
            string version = this.version.ToString();
            string pmName = this.pm.Nom;
        }
    }
}
