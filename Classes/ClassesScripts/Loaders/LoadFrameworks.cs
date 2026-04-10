using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;

namespace CodeInstaller.Classes.ClassesScripts.Loaders {
    public class LoadFrameworks {
        private Dictionary<string, Framework> listeFrameworksJS;
        private Dictionary<string, Framework> listeFrameworksPHP;

        public LoadFrameworks() {
            this.listeFrameworksJS = new Dictionary<string, Framework>();
            this.listeFrameworksPHP = new Dictionary<string, Framework>();
            this.listeFrameworksJS = LoadFrameworks.loadJsFrameworks();
            this.listeFrameworksPHP = LoadFrameworks.loadPHPFrameworks();
        }

        public static Dictionary<string, Framework> loadJsFrameworks() {
            Dictionary<string, Framework> alisteFrameworksJS = new Dictionary<string, Framework>();
            LoadPackagesManager lesPm = new LoadPackagesManager();
            Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();
            var pathjson = Path.Combine(AppContext.BaseDirectory,"Classes", "ClassesScripts", "Loaders", "Src", "FrameworksJS.json");

            string json = File.ReadAllText(pathjson);

            List<Framework> lesFrameworksJs = JsonConvert.DeserializeObject<List<Framework>>(json);

            foreach (var unFrameworkJS in lesFrameworksJs) {
                unFrameworkJS.Pm = lesPmCharges["Npm"];
                alisteFrameworksJS.Add(unFrameworkJS.Nom, unFrameworkJS);
            }

            return alisteFrameworksJS;
        }

        public static Dictionary<string, Framework> loadPHPFrameworks() {
            Dictionary<string, Framework> alisteFrameworksPHP = new Dictionary<string, Framework>();
            LoadPackagesManager lesPm = new LoadPackagesManager();
            Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();

            var pathjson = Path.Combine(AppContext.BaseDirectory, "Classes", "ClassesScripts", "Loaders", "Src", "frameworksPHP.json");

            string json = File.ReadAllText(pathjson);

            List<Framework> lesFrameworksPHP = JsonConvert.DeserializeObject<List<Framework>>(json);

            foreach (var unFrameworkPHP in lesFrameworksPHP) {
                unFrameworkPHP.Pm = lesPmCharges["Composer"];
                alisteFrameworksPHP.Add(unFrameworkPHP.Nom, unFrameworkPHP);
            }

            return alisteFrameworksPHP;
        }
    }
}