namespace museumApp;

public partial class History : ContentPage
{
    Shared shared = new Shared();
	public History()
	{
		InitializeComponent();
        exampleMuseumBtn.Clicked += shared.clickHandler;
	}
}