using CodeInstaller.Classes;
using CodeInstaller.Classes.ClassesScripts.Loaders;
namespace CodeInstaller.Screens;

public partial class MenuCreationProjet : ContentPage
{
	public MenuCreationProjet()
	{
		InitializeComponent();
		BindingContext = new LoadLangages();
	}
}