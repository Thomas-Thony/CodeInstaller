using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders {
    public class LoadLangages {
        public List<Langage> lesLangages;
        public LoadLangages() {
            LoadFrameworks lesFrameworks = new LoadFrameworks();
            PHP php = new PHP("PHP", lesFrameworks.loadPHPFrameworks());
            Javascript JS = new Javascript("Javascript", lesFrameworks.loadJsFrameworks());

            this.lesLangages.Add(php);
            this.lesLangages.Add(JS);
        }
    }
}
