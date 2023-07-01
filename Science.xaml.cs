namespace museumApp;

public partial class Science : ContentPage
{
	readonly Shared shared = new();
	public Science()
	{
		InitializeComponent();
		techStudyStore.Clicked += shared.clickHandler;
		illusionsMuseum.Clicked += shared.clickHandler;
        medicalMuseum.Clicked += shared.clickHandler;
    }
}