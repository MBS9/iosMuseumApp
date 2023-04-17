namespace museumApp;

public partial class NewPage1 : ContentPage
{
    Shared shared = new();
	public NewPage1()
	{
		InitializeComponent();
        _ = LoadAsset();
	}

    private void moreDetailsClicked(object sender, EventArgs e)
    {
		expandButton.IsVisible	= false;
		details.IsVisible = true;
    }

    async Task LoadAsset()
    {
        var page = Preferences.Get(shared.pageSymbol, "example_museum");
        Preferences.Remove(shared.pageSymbol);
        using var stream = await FileSystem.OpenAppPackageFileAsync(page+".txt");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
        mainImage.Source = page + ".png";

        var splitList = contents.Split('\n');
        Title = splitList[0];
        h1.Text = splitList[0];
        intro.Text = splitList[1];
        location.Text = splitList[2];
        review.Text = splitList[3];
    }
}