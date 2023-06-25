namespace museumApp;

public partial class PopArts : ContentPage
{
    readonly Shared shared = new();
    public PopArts()
	{
		InitializeComponent();
        TheLudwigMuseum.Clicked += shared.clickHandler;
    }
}