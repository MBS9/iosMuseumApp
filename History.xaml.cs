namespace museumApp;

public partial class History : ContentPage
{
    readonly Shared shared = new();
    public History()
	{
		InitializeComponent();
        exampleMuseumBtn.Clicked += shared.clickHandler;
	}
}