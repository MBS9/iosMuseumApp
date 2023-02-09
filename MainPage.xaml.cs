namespace museumApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        var result = Preferences.Get("favColor", "fill out the Interests Quiz so we know");
		personalizedGreeting.Text = "Your best prefered colour: " + result + "!";
    }
}
