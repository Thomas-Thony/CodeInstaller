using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public class CodeInit {
        private string projectPath;

        public CodeInit(string path) {
            this.ProjectPath = path;
        }

        public string ProjectPath { get => projectPath; set => projectPath = value; }
    
        public static void CreateProject(Framework aFramework, string path) {
            aFramework.createProjectFromFramework(path, "Mon_projet_de_test");
        }
    }
}
