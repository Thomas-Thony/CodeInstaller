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
    }
}
