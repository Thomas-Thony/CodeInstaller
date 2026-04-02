using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders
{
    class JSFrameworks {
        private Dictionary<string, Framework> listeFrameworks;
        public JSFrameworks() {
            
        }

        public Dictionary<string, Framework> loadJsFrameworks() {
           LoadPackagesManager lesPm = new LoadPackagesManager();
           Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();
           Framework React = new Framework("React", "", (decimal)18.9, "https://github.com/facebook/react", lesPmCharges["Npm"]);
           return this.listeFrameworks;
        }
    }
}
