using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders
{
    public class LoadPackagesManager {
        private Dictionary<string, PackageManager> listePM;

        public LoadPackagesManager() {

        }

        public Dictionary<string, PackageManager> loadPM() {
            PackageManager Cargo = new PackageManager("Cargo", (decimal)0.95, "cargo");
            PackageManager CocoaPods = new PackageManager("CocoaPods", (decimal)1.16, "pod");
            PackageManager Composer = new PackageManager("Composer", (decimal)2.9, "composer");
            PackageManager Conda = new PackageManager("Conda", (decimal)25.11, "conda");
            PackageManager CRAN = new PackageManager("CRAN", (decimal)4.5, "install.packages");
            PackageManager Deno = new PackageManager("Deno", (decimal)2.7, "deno");
            PackageManager Docker = new PackageManager("Docker", (decimal)29.3, "docker");
            PackageManager Gradle = new PackageManager("Gradle", (decimal)9.4, "gradlew");
            PackageManager Leiningen = new PackageManager("Leiningen", (decimal)2.12, "lein");
            PackageManager LuaRocks = new PackageManager("Luarocks", (decimal)3.10, "luarocks ");
            PackageManager Maven = new PackageManager("Maven", (decimal)3.9, "mvn");
            PackageManager Npm = new PackageManager("Npm", (decimal)11.7, "npm");
            PackageManager NuGet = new PackageManager("Nuget", (decimal)6.11, "dotnet");
            return this.listePM;
        }
    }
}
