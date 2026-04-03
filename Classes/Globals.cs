using CodeInstaller.Classes.ClassesScripts.Loaders;
using Microsoft.Maui.Animations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public class Globals {
        public static Dictionary<string, PackageManager> lesPm = Globals.getPm();
        
        public static Dictionary<string, PackageManager> getPm() {
            LoadPackagesManager lesPm = new LoadPackagesManager();
            return lesPm.loadPM();
        }
    }
}
