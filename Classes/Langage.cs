using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public abstract class Langage {
        private string aLangage;
        private List<Framework> frameworks;
        private PackageManager packageManager;

        public Langage(string aLangage, List<Framework> desFrameworks, PackageManager aPackageManager) {
            this.aLangage = aLangage;
            this.Frameworks = desFrameworks;
            this.PackageManager = aPackageManager;
        }

        public string ALangage { get => aLangage; set => aLangage = value; }
        public List<Framework> Frameworks { get => frameworks; set => frameworks = value; }
        public PackageManager PackageManager { get => packageManager; set => packageManager = value; }

        public void createProjectFromFramework(Framework aFramework, PackageManager aPackageManager) {
            string cmdPM = aPackageManager.Cmd;
            string framework = aFramework.Nom;
            string cmd = cmdPM + framework;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
