using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public class PackageManager {
        private string nom;
        private int version;
        private string cmd;

        public PackageManager(string nom, int version, string cmd) {
            this.nom = nom;
            this.version = version;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Version { get => version; set => version = value; }
        public string Cmd { get => cmd; set => cmd = value; }
    }
}
