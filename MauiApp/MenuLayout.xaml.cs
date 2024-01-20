namespace MauiApp1;

public partial class MenuLayout : FlyoutPage
{
	public MenuLayout()
	{
        InitializeComponent();
        Detail = new NavigationPage(new MainPage());
        Flyout = new Flyout();
    }
}