namespace museumApp;

public partial class Science : ContentPage
{
	readonly Shared shared = new();
	public Science()
	{
		InitializeComponent();
		techStudyStore.Clicked += shared.clickHandler;
		IllusionsMuseum.Clicked += shared.clickHandler;
        SemmelweisMuseum.Clicked += shared.clickHandler;
    }
}