namespace museumApp;

public partial class History : ContentPage
{
    readonly Shared shared = new();
    public History()
	{
		InitializeComponent();
        holocaustMemorial.Clicked += shared.clickHandler;
        nationalMuseum.Clicked += shared.clickHandler;
        aquincumMuseum.Clicked += shared.clickHandler;
    }
}