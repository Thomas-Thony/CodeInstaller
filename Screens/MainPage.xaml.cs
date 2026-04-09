using CodeInstaller.Classes;
using CodeInstaller.Classes.ClassesScripts;
using CodeInstaller.Classes.ClassesScripts.Loaders;
using Microsoft.Maui.Controls.PlatformConfiguration;
using CommunityToolkit.Maui;

namespace CodeInstaller.Screens;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object? sender, EventArgs e) {

        

        /*
        Framework Vite = new Framework("Vite", (decimal)8.0, "vite", "https://github/facebook/react", Globals.lesPm["Npm"], "react.png");
        CodeInit.CreateProject(Vite, "./");
        */
        /*
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
        */
    }

    async void onCreateProjectCliked(object? sender, EventArgs e) {
        await Navigation.PushAsync(new MenuCreationProjet());
    }
}
