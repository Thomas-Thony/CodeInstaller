using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders
{
    public class LoadPackagesManager {
        private Dictionary<string, PackageManager> listePM;

        public LoadPackagesManager() {
            this.listePM = new Dictionary<string, PackageManager>();
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
            PackageManager Pip = new PackageManager("Pip", (decimal)25.3, "pip");
            PackageManager Podman = new PackageManager("Podman", (decimal)5.8, "podman");
            PackageManager RubyGem = new PackageManager("Rubygem", (decimal)4.0, "gem");
            PackageManager Sbt = new PackageManager("Sbt", (decimal)1.10, "sbt");
            PackageManager Vcpkg = new PackageManager("vcpkg", (decimal)2026.03, "vcpkg");
            PackageManager Yarn = new PackageManager("Yarn", (decimal)4.12, "yarn");

            this.listePM.Add("Cargo", Cargo);
            this.listePM.Add("CocoaPods", CocoaPods);
            this.listePM.Add("Composer", Composer);
            this.listePM.Add("Conda", Conda);
            this.listePM.Add("CRAN", CRAN);
            this.listePM.Add("Deno", Deno);
            this.listePM.Add("Docker", Docker);
            this.listePM.Add("Gradle", Gradle);
            this.listePM.Add("Leiningen", Leiningen);
            this.listePM.Add("LuaRocks", LuaRocks);
            this.listePM.Add("Maven", Maven);
            this.listePM.Add("Npm", Npm);
            this.listePM.Add("NuGet", NuGet);
            this.listePM.Add("Pip", Pip);
            this.listePM.Add("Podman", Podman);
            this.listePM.Add("RubyGem", RubyGem);
            this.listePM.Add("Sbt", Sbt);
            this.listePM.Add("Vcpkg", Vcpkg);
            this.listePM.Add("Yarn", Yarn);

            return this.listePM;
        }
    }
}
