namespace museumApp;

public partial class Science : ContentPage
{
	public Science()
	{
		InitializeComponent();
	}
    private async void exampleMuseumBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("exampleMuseum");
    }
}