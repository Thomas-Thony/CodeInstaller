using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders {
    public record  LoadLangages {
        public List<Langage> lesLangages;
        public LoadLangages() {
            PHP php = new PHP("PHP", LoadFrameworks.loadPHPFrameworks());
            Javascript JS = new Javascript("Javascript", LoadFrameworks.loadJsFrameworks());
            List<Langage> lesLangages = new List<Langage>();
            this.lesLangages = lesLangages;
            this.lesLangages.Add(php);
            this.lesLangages.Add(JS);
        }
    }
}
