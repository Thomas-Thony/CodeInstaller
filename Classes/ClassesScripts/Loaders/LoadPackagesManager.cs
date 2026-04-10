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
            PackageManager Cargo = new PackageManager("Cargo", (decimal)0.95, "cargo", "", "cargo new");
            PackageManager CocoaPods = new PackageManager("CocoaPods", (decimal)1.16, "pod", "pod install", "");
            PackageManager Composer = new PackageManager("Composer", (decimal)2.9, "composer", "composer install || composer update", "composer create-project");
            PackageManager Conda = new PackageManager("Conda", (decimal)25.11, "conda", "", "conda activate");
            PackageManager CRAN = new PackageManager("CRAN", (decimal)4.5, "install.packages", "", "");
            PackageManager Deno = new PackageManager("Deno", (decimal)2.7, "deno", "deno install", "deno init");
            PackageManager Docker = new PackageManager("Docker", (decimal)29.3, "docker", "", "");
            PackageManager Gradle = new PackageManager("Gradle", (decimal)9.4, "gradle", "", "gradle init");
            PackageManager Leiningen = new PackageManager("Leiningen", (decimal)2.12, "lein", "", "lein new app");
            PackageManager LuaRocks = new PackageManager("Luarocks", (decimal)3.10, "luarocks", "luarocks install", "luarocks make");
            PackageManager Maven = new PackageManager("Maven", (decimal)3.9, "mvn", "", "mvn archetype:generate");
            PackageManager Npm = new PackageManager("Npm", (decimal)11.7, "npm", "npm i", "npm init -y");
            PackageManager NuGet = new PackageManager("Nuget", (decimal)6.11, "dotnet", "", "");
            PackageManager Pip = new PackageManager("Pip", (decimal)25.3, "pip", "pip install", "");
            PackageManager Podman = new PackageManager("Podman", (decimal)5.8, "podman", "", "podman machine init");
            PackageManager RubyGem = new PackageManager("Rubygem", (decimal)4.0, "gem", "gem install", "bundle gem");
            PackageManager Sbt = new PackageManager("Sbt", (decimal)1.10, "sbt", "", " sbt new");
            PackageManager Vcpkg = new PackageManager("vcpkg", (decimal)2026.03, "vcpkg", "", "git clone https://github.com/microsoft/vcpkg.git");
            PackageManager Yarn = new PackageManager("Yarn", (decimal)4.12, "yarn", "yarn add", "yarn init");

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
