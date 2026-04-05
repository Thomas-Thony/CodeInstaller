using CodeInstaller.Classes;

namespace CodeInstaller.Screens;

public partial class MenuChoixFramework : ContentPage {
    public MenuChoixFramework(Langage aLangage) {
		InitializeComponent();
        lesFrameworks.ItemsSource = new List<Framework>(aLangage.Frameworks.Values);
    }

    private void CreateProjet(object sender, EventArgs e) {

    }
}