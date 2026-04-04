using CodeInstaller.Classes;
using CodeInstaller.Classes.ClassesScripts.Loaders;
namespace CodeInstaller.Screens;

public partial class MenuCreationProjet : ContentPage
{
	public MenuCreationProjet()	{
		InitializeComponent();
        CollectionLangages.ItemsSource = LoadLangages.getLangages();
    }

    private void CounterBtn_Clicked(object sender, EventArgs e) {

    }

    private void OnCreatePorjectByLangage(object sender, EventArgs e) {

    }
}