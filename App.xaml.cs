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
#if DEBUG
        Console.WriteLine("Running tests");
        Preferences.Set(shared.pageSymbol, "museum");
        Shell.Current.GoToAsync("exampleMuseum");
        Shell.Current.GoToAsync("..");
        base.OnStart();
#endif
    }
}
