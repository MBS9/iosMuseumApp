namespace museumApp;

public partial class VisualArts : ContentPage
{
	public VisualArts()
	{
		InitializeComponent();
	}
	private async void exampleMuseumBtn_Clicked(object sender, EventArgs e)
    {
		Preferences.Set("page", "mng");
		await Shell.Current.GoToAsync("exampleMuseum");
    }
}