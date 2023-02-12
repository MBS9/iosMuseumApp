namespace museumApp;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
	}
    private async void exampleMuseumBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("exampleMuseum");
    }
}