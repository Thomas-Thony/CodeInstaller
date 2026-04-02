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
        private string command;
        private string documentationGithub;
        private PackageManager pm;

        public Framework(string aNom, string aCommand , decimal uneVersion, string lienDocGithub, PackageManager aPm) {
            this.Nom = aNom;
            this.Command = aCommand;
            this.Version = uneVersion;
            this.DocumentationGithub = lienDocGithub;
            this.pm = aPm;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string Command { get => command; set => command = value; }
        public string DocumentationGithub { get => documentationGithub; set => documentationGithub = value; }

        public void createProjectFromFramework() {
            string cmd = this.Command;
            string version = this.version.ToString();
            string pmName = this.pm.Nom;

            string shellCmd = pmName + cmd;
            
        }
    }
}
