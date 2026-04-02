using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CodeInstaller.Classes
{
    public abstract class Langage
    {
        private string aLangage;
        private List<Framework> frameworks;
        private PackageManager packageManager;

        public Langage(string aLangage, List<Framework> desFrameworks, PackageManager aPackageManager)
        {
            this.aLangage = aLangage;
            this.Frameworks = desFrameworks;
            this.PackageManager = aPackageManager;
        }

        public string ALangage { get => aLangage; set => aLangage = value; }
        public List<Framework> Frameworks { get => frameworks; set => frameworks = value; }
        public PackageManager PackageManager { get => packageManager; set => packageManager = value; }

        public void createProjectFromFramework(Framework aFramework, PackageManager aPackageManager, string path)
        {
            string cmdPM = aPackageManager.Cmd;
            string framework = aFramework.Nom;
            string cmd = "/ C " + path + cmdPM + framework;
            Console.WriteLine("Lancement du script");
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Maximized,
                FileName = "cmd.exe",
                Arguments = cmd,
            };
            process.Start();
            process.StartInfo.RedirectStandardOutput = true;
            process.StandardInput.WriteLine(cmd);
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
            }
            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            Console.ReadKey();
            Console.WriteLine("Script terminé !");
        }

        public void testCmdFromCsharp()
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C ipconfig";
                process.StartInfo.WorkingDirectory = @"C:\";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                

                Debug.WriteLine("ipconfig output:");
                Debug.WriteLine(output);
                if (!string.IsNullOrEmpty(error))
                {
                    Debug.WriteLine("ipconfig error:");
                    Debug.WriteLine(error);
                }
            }
        }
    }
}