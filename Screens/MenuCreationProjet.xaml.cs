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

    async void OnCreatePorjectByLangage(object sender, EventArgs e) {
        if (sender is Button btn && btn.CommandParameter is Langage lang){
            await Navigation.PushAsync(new MenuChoixFramework(lang)); 
        }
    }
}