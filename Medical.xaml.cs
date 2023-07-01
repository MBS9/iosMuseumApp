namespace museumApp;

public partial class Medical : ContentPage
{
    readonly Shared shared = new();
    public Medical()
	{
		InitializeComponent();
        SemmelweisMuseum.Clicked += shared.clickHandler;
	}
}