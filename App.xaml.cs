namespace museumApp;

public partial class App : Application
{
    Shared shared = new();
    public App()
	{
		InitializeComponent();
		Current.UserAppTheme = AppTheme.Light;
		MainPage = new AppShell();
    }
}
