namespace museumApp;

public partial class Other : ContentPage
{
    readonly Shared shared = new();
    public Other()
	{
		InitializeComponent();
		moneyMuseum.Clicked += shared.clickHandler;
	}
}