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

        public Framework(string aNom, decimal uneVersion, string lienDocGithub, PackageManager aPm) {
            this.Nom = aNom;
            this.Version = uneVersion;
            this.DocumentationGithub = lienDocGithub;
            this.pm = aPm;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string DocumentationGithub { get => documentationGithub; set => documentationGithub = value; }

        public void createProjectFromFramework() {
            string version = this.version.ToString();
            string pmName = this.pm.Nom;
        }
    }
}
