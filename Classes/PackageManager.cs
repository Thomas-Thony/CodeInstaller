using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public class PackageManager {
        private string nom;
        private decimal version;
        private string cmd;

        public PackageManager(string nom, decimal version, string cmd) {
            this.nom = nom;
            this.version = version;
            this.cmd = cmd;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string Cmd { get => cmd; set => cmd = value; }
    }
}
