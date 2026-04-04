using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInstaller.Classes.ClassesScripts.Loaders {
    public record  LoadLangages {
        public List<Langage> lesLangages;
        public static List<Langage> getLangages() {
            List<Langage> lesLangages = new List<Langage>();
            Javascript JS = new Javascript(1, "Javascript", LoadFrameworks.loadJsFrameworks(), "js.png");
            PHP Php = new PHP(2, "PHP", LoadFrameworks.loadPHPFrameworks(), "php.png");
            lesLangages.Add(JS);
            lesLangages.Add(Php);

            return lesLangages;
        }
    }
}
