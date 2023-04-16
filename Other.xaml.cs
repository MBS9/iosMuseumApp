namespace museumApp;

public partial class Other : ContentPage
{
	Shared shared = new();
	public Other()
	{
		InitializeComponent();
		exampleMuseumBtn.Clicked += shared.clickHandler;
	}
}