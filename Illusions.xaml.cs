namespace museumApp;

public partial class Illusions : ContentPage
{
    readonly Shared shared = new();
    public Illusions()
	{
		InitializeComponent();
        IllusionsMuseum.Clicked += shared.clickHandler;
	}
}