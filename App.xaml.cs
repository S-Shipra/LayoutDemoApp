namespace LayoutsDemoApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // This bypasses AppShell and goes straight to your dashboard!
        MainPage = new NavigationPage(new Pages.MainPage());
    }
}