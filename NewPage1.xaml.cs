namespace museumApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void moreDetailsClicked(object sender, EventArgs e)
    {
		expandButton.IsVisible	= false;
		details.IsVisible = true;
    }
}