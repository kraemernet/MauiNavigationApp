namespace MauiApp1;

public partial class Flyout : ContentPage
{
	public Flyout()
	{
		InitializeComponent();
	}

    private void MeinPage_Clicked(object sender, EventArgs e)
    {
        if (Parent is FlyoutPage flyoutPage)
            flyoutPage.Detail = new NavigationPage(new MainPage());
    }

    private void SettingsPage_Clicked(object sender, EventArgs e)
    {
        if (Parent is FlyoutPage flyoutPage)
            flyoutPage.Detail = new NavigationPage(new SettingsPage());
    }
}