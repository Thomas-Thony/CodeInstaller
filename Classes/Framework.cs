using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CodeInstaller.Classes
{
    public class Framework {
        private string nom;
        private decimal version;
        private string command;
        private string documentationGithub;

        public Framework(string aNom, decimal uneVersion, string lienDocGithub) {
            this.Nom = aNom;
            this.Version = uneVersion;
            this.DocumentationGithub = lienDocGithub;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string Command { get => command; set => command = value; }
        public string DocumentationGithub { get => documentationGithub; set => documentationGithub = value; }
    }
}
