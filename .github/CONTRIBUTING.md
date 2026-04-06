# Contribution

## Que faire pour contribuer
Vous pouvez contribuer à ce projet en faisant des fixes demandés dans les issues, créer des tests unitaires ou encore faire de la documentation.

### Pour tous les contributeurs
Vous pouvez créer une fork à la branche master de ce projet.
Pour soumettre vos changements, effectuez une pull request avec une description détaillée de vos modifications apportées (il peut y avoir beaucoup de lignes à voir, alors rendez le travail de la revue de code simple). <br>

### Pour ceux qui codent
Pour une meilleure maintenance, et compréhension par tout le monde, merci d'utiliser les différentes conventions de code déjà en place.
Evidemment, des commentaires sur vos ajouts sont très appréciés.

#### Ajouter un nouveau langage 

Vous pouvez ajouter un nouveau langage, créez un fichier frameworksLeLangage.json dans le dossier ./Classes/ClassesScripts/Loaders/Src/.
Ensuite, dans le fichier LoadFrameworks.cs créez un HashMap (ou dictionnaire) tel que :
```csharp
public class LoadFrameworks {
	private Dictionary <string, Framework> lesFrameworksLangage;
}
```

En ajoutez dans le constructeur une attribution d'une fonction retournant ce hashmap :

```csharp
public class LoadFrameworks {
	private Dictionary <string, Framework> lesFrameworksLangage;

	public LoadFrameworks(){
		 this.listeFrameworksLangages = new Dictionary<string, Framework>();
         this.listeFrameworksLangages = LoadFrameworks.loadLangageFrameworks();
	}

	public  Dictionary<string, Framework> loadLangageFrameworks() {
            Dictionary<string, Framework> alisteFrameworksKangage = new Dictionary<string, Framework>();
            LoadPackagesManager lesPm = new LoadPackagesManager();
            Dictionary<string, PackageManager> lesPmCharges = lesPm.loadPM();
            var pathjson = Path.Combine(AppContext.BaseDirectory,"Classes", "ClassesScripts", "Loaders", "Src", "frameworksLangage.json");

            string json = File.ReadAllText(pathjson);

            List<Framework> lesFrameworksLangage = JsonConvert.DeserializeObject<List<Framework>>(json);

            foreach (var unFrameworkLangage in lesFrameworksLangage) {
                alisteFrameworksKangage.Add(unFrameworkLangage.Nom, unFrameworkLangage);
            }

            return alisteFrameworksKangage;
        }
}
```

Enfin, dans LoadLangages, créez un objet langage tel que : 

```csharp
public static List<Langage> getLangages() {
            List<Langage> lesLangages = new List<Langage>();
            VotreClasseLangage VotreClasseLangage = new VotreLangage(X, "NomLangage", LoadFrameworks.loadLangageFrameworks(), "logoLangage.png");
            lesLangages.Add(VotreLangage);

            return lesLangages;
        }
```

### Pour ceux qui documentent
Pas besion d'être une grande personne de lettre, du moment que c'est lisible et compréhensible par le premier venu.