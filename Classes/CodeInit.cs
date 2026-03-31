using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes
{
    public class CodeInit{
        private bool latest = true;
        private string projectPath;

        public CodeInit(bool? stateVersion, string path) {
            this.latest = stateVersion ?? true;
            this.ProjectPath = path;
        }

        public bool Latest { get => latest; set => latest = value; }
        public string ProjectPath { get => projectPath; set => projectPath = value; }
    }
}
