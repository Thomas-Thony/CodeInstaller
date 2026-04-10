using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CodeInstaller.Classes
{
    public class PackageManager
    {
        private string nom;
        private decimal version;
        private string cmd;
        private string installcmd;
        private string createcmd;

        public PackageManager(string nom, decimal version, string cmd, string installCmd, string createCmd) {
            this.nom = nom;
            this.version = version;
            this.cmd = cmd;
            this.installcmd = installCmd;
            this.createcmd= createCmd;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal Version { get => version; set => version = value; }
        public string Cmd { get => cmd; set => cmd = value; }
        public string Installcmd { get => installcmd; set => installcmd = value; }
        public string Createcmd { get => createcmd; set => createcmd = value; }

        public void installDependencies(string frameworkName) {
            try {
                using Process process = new Process {
                    StartInfo = new ProcessStartInfo {
                        FileName = "cmd.exe",
                        UseShellExecute = true,
                        Arguments = "/k" + this.Installcmd + " " + frameworkName,
                    }
                };
                process.Start();
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de l'éxécution de la commande :" + e.Message);
            }
        }

        public void createProject(string nomProjet) {
            try {
                using Process process = new Process {
                    StartInfo = new ProcessStartInfo {
                        FileName = "cmd.exe",
                        UseShellExecute = true,
                        Arguments = "/k" + this.createcmd + " " + nomProjet,
                    }
                };
                process.Start();
            } catch (Exception e) {
                Console.WriteLine("Erreur lors de l'éxécution de la commande :" + e.Message);
            }
        }

        public void createProjectFromFramework(Framework aFramework, string path, string nomProjet){
            try {
                using Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        UseShellExecute = true,
                        Arguments = "/k" + "cd " + path,
                    }
                };
                process.Start();
            }
            catch (Exception e) {
                Console.WriteLine("Erreur lors de l'éxécution de la commande :" + e.Message);
            }
            this.installDependencies(aFramework.Nom);
            this.createProject(nomProjet);
        }
    }
}