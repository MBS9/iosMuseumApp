namespace museumApp;

public partial class VisualArts : ContentPage
{
    Shared shared = new Shared();
    public VisualArts()
	{
		InitializeComponent();
        nationalGallery.Clicked += shared.clickHandler;
    }
}