namespace museumApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("exampleMuseum", typeof(NewPage1));
	}
}
