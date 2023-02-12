namespace museumApp;

public partial class VisualArts : ContentPage
{
	public VisualArts()
	{
		InitializeComponent();
	}
	private async void exampleMuseumBtn_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("exampleMuseum");
    }
}