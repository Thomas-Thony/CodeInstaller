using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace CodeInstaller.Classes.ClassesScripts.Loaders {
    public class LoadFrameworks {
        private Dictionary<string, Framework> listeFrameworksJS;
        private Dictionary<string, Framework> listeFrameworksPHP;

        public LoadFrameworks() {
            this.listeFrameworksJS = this.loadJsFrameworks();
            this.listeFrameworksPHP = this.loadPHPFrameworks();
        }

        public Dictionary<string, Framework> loadJsFrameworks() {
            LoadPackagesManager lesPm = new LoadPackagesManager();
            Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();

            string json = File.ReadAllText("./Src/frameworksJS.json");

            var options = new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true
            };

            List<Framework> lesFrameworksJs = JsonSerializer.Deserialize<List<Framework>>(json, options);

            foreach (var unFramework in lesFrameworksJs) {
                this.listeFrameworksJS.Add(unFramework.Nom, unFramework);
            }

            return this.listeFrameworksJS;
        }

        public Dictionary<string, Framework> loadPHPFrameworks() {
            LoadPackagesManager lesPm = new LoadPackagesManager();
            Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();

            string json = File.ReadAllText("./Src/frameworksPHP.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Framework> lesFrameworksJs = JsonSerializer.Deserialize<List<Framework>>(json, options);

            foreach (var unFramework in lesFrameworksJs) { 
                this.listeFrameworksPHP.Add(unFramework.Nom, unFramework);
            }

            return this.listeFrameworksPHP;
        }
    }
}