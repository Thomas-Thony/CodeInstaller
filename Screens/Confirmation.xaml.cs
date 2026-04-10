using CodeInstaller.Classes;
using CommunityToolkit.Maui.Storage;
namespace CodeInstaller.Screens;

public partial class Confirmation : ContentPage
{
    Framework leFramework;
    string chemin;

	public Confirmation(Framework aFramework) {
		InitializeComponent();
        leFramework = aFramework;
        chemin = "./";
    }

    private async void ChoisirDossierAsync(object sender, EventArgs e) {
        chemin = await PickerDossierAsync();
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e) {
        
    }

    private void OnCreateProjet(object sender, EventArgs e) {
        string nomProjet = nomProjetEntry.Text;
        leFramework.Pm.createProjectFromFramework(leFramework, chemin, nomProjet);
    }

    private async Task<string> PickerDossierAsync() {
        var result = await FolderPicker.Default.PickAsync(CancellationToken.None);
        if (result.IsSuccessful) {
            return result.Folder.Path;
        } else {
            return "./";
        }
    }

}