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

        public string create(Framework aFramework, string nomProjet) {
            string args = "";

            switch (aFramework.Pm.Nom) {
                case "Cargo":
                    args = "new";
                    break;

                case "CocoaPods":
                    args = "install";
                    break;

                case "Composer" :
                    args = "require";
                    break;

                case "Conda" :
                    args = "activate";
                    break;

                case "Deno" :
                    args = "init";
                    break;
                
                case "Docker" :
                    args = "compose";
                    break;

                case "Gradle" :
                    args = "init";
                    break;

                case "Leiningen":
                    args = "new";
                    break;

                case "LuaRocks":
                    args = "install";
                    break;

                case "Npm":
                    args = "create";
                    break;

                case "Nuget":
                    args = "init";
                    break;

                case "Pip":
                    args = "-init";
                    break;

                case "Podman":
                    args = "-init";
                    break;

                case "RubyGem":
                    args = "install";
                    break;

                case "Vcpkg":
                    args = "new";
                    break;

                case "Yarn":
                    args = "init";
                    break;
            } 
            return this.cmd + " " + args + " " + aFramework.Packagename + " " + nomProjet + " -- --template react";
        }

        public string install(Framework aFramework) {
             string args = "";

            switch (aFramework.Pm.Nom) {
                case "Cargo":
                    args = "new";
                    break;

                case "CocoaPods":
                    args = "install";
                    break;

                case "Composer" :
                    args = "require";
                    break;

                case "Conda" :
                    args = "activate";
                    break;

                case "Deno" :
                    args = "init";
                    break;
                
                case "Docker" :
                    args = "compose";
                    break;

                case "Gradle" :
                    args = "init";
                    break;

                case "Leiningen":
                    args = "new";
                    break;

                case "LuaRocks":
                    args = "install";
                    break;

                case "Npm":
                    args = "install";
                    break;

                case "Nuget":
                    args = "install";
                    break;

                case "Pip":
                    args = "install";
                    break;

                case "Podman":
                    args = "install";
                    break;

                case "RubyGem":
                    args = "install";
                    break;

                case "Vcpkg":
                    args = "install";
                    break;

                case "Yarn":
                    args = "install";
                    break;
            }
            return this.cmd + " " + "install" + " " + aFramework.Packagename;
        }
    }
}
