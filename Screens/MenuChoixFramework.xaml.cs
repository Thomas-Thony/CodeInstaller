using CodeInstaller.Classes;

namespace CodeInstaller.Screens;

public partial class MenuChoixFramework : ContentPage {
    public MenuChoixFramework(Langage aLangage) {
		InitializeComponent();
        lesFrameworks.ItemsSource = new List<Framework>(aLangage.Frameworks.Values);
    }

    async void CreateProjet(object sender, EventArgs e) {
       await Navigation.PushAsync(new Confirmation());
    }
}