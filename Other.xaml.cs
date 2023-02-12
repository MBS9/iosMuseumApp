namespace museumApp;

public partial class Other : ContentPage
{
	public Other()
	{
		InitializeComponent();
	}
    private async void exampleMuseumBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("exampleMuseum");
    }
}