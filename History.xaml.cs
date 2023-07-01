namespace museumApp;

public partial class History : ContentPage
{
    readonly Shared shared = new();
    public History()
	{
		InitializeComponent();
        holocaustMemorial.Clicked += shared.clickHandler;
        NationalMuseum.Clicked += shared.clickHandler;
    }
}