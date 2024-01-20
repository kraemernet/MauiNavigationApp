namespace MauiApp1;

public partial class SettingsPage : ContentPage
{    public SettingsPage()
	{
        InitializeComponent();
    }

    private void GoToSubPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SettingsSubPage());
    }
}