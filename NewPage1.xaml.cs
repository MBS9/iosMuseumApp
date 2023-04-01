namespace museumApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        LoadAsset();
	}

    private void moreDetailsClicked(object sender, EventArgs e)
    {
		expandButton.IsVisible	= false;
		details.IsVisible = true;
    }

    async Task LoadAsset()
    {
        var page = Preferences.Get("page", "lorem");
        Preferences.Remove("page");
        using var stream = await FileSystem.OpenAppPackageFileAsync(page+".txt");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();

        var splitList = contents.Split('\n');
        Title = splitList[0];
        h1.Text = splitList[0];
        intro.Text = splitList[1];
        location.Text = splitList[2];
        review.Text = splitList[3];
    }
}