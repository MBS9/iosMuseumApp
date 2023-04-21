namespace museumApp;

public partial class VisualArts : ContentPage
{
    readonly Shared shared = new();
    public VisualArts()
	{
		InitializeComponent();
        nationalGallery.Clicked += shared.clickHandler;
    }
}