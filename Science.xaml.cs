namespace museumApp;

public partial class Science : ContentPage
{
	Shared shared = new();
	public Science()
	{
		InitializeComponent();
		exampleMuseumBtn.Clicked += shared.clickHandler;
	}
}