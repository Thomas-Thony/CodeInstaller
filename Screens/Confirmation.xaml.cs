using CommunityToolkit.Maui.Storage;
namespace CodeInstaller.Screens;

public partial class Confirmation : ContentPage
{
	public Confirmation()
	{
		InitializeComponent();
	}

    private async void ChoisirDossierAsync(object sender, EventArgs e)
    {
        var result = await FolderPicker.Default.PickAsync(CancellationToken.None);

        if (result.IsSuccessful) {
            string chemin = result.Folder.Path;
            string nom = result.Folder.Name;
            await Shell.Current.DisplayAlert( "Dossier sélectionné", chemin, "OK");
        }
    }

}