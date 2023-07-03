namespace museumApp;

public partial class VisualArts : ContentPage
{
    readonly Shared shared = new();
    public VisualArts()
	{
		InitializeComponent();
        TheLudwigMuseum.Clicked += shared.clickHandler;
        MaiManoMuseum.Clicked += shared.clickHandler;
        mucsarnokMuseum.Clicked += shared.clickHandler;
        museumFineArts.Clicked += shared.clickHandler;
    }
}