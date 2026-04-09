using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using CodeInstaller.Classes;

namespace CodeInstaller.Classes
{
    public class Framework {
        private string nom;
        private decimal version;
        private string documentationGithub;
        private string packagename;
        private PackageManager pm;
        private List<string> lesVersions;
        private string logo;

        public Framework(string aNom, decimal uneVersion, string apackagename,  string lienDocGithub, PackageManager aPm, string unLogo) {
            this.Nom = aNom;
            this.Version = uneVersion;
            this.Packagename = apackagename;
            this.DocumentationGithub = lienDocGithub;
            this.Pm = aPm;
            this.logo = unLogo;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string DocumentationGithub { get => documentationGithub; set => documentationGithub = value; }
        public string Logo { get => logo; set => logo = value; }
        public PackageManager Pm { get => pm; set => pm = value; }
        public string Packagename { get => packagename; set => packagename = value; }

        public void createProjectFromFramework(string path, string nomProjet, string? command = null) {

            try {
                using Process process = new Process {
                    StartInfo = new ProcessStartInfo {
                        FileName = "cmd.exe",
                        UseShellExecute = true,
                        Arguments = "/k" + "cd " + path + "&& " + this.pm.install(this) + " || " + this.pm.create(this, nomProjet),
                    }
                };
                process.Start();
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de l'éxécution de la commande :" + e.Message);
            }
        }
    }
}
