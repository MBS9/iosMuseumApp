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
	protected override void OnStart()
	{
        var test = Environment.GetEnvironmentVariable("MUSEUM_APP_TEST");
        if (test != "test")
        {
            return;
        }
        Console.WriteLine("Running tests");
        Preferences.Set(shared.pageSymbol, "museum");
        Shell.Current.GoToAsync("exampleMuseum");
    }
}
