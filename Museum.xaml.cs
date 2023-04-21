namespace museumApp;

public partial class Museum : ContentPage
{
    readonly Shared shared = new();
	public Museum()
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

        var splitList = contents.Split("---");
        Title = splitList[0];
        h1.Text = splitList[0];
        description.Text = splitList[1];
        exhibitions.Text = splitList[2];
        info.Text = splitList[3];
        impressions.Text = splitList[4];
        tips.Text = splitList[5];
        top5.Text = splitList[6];
        plus.Text = splitList[7];
        string[] imagesLocation = splitList[8].Split('\n');
        foreach (var image in imagesLocation)
        {
            var imagePath = image.Trim('\r');
            if (imagePath != "")
            {
                images.Add(new Image { Source = imagePath, HeightRequest=100 });
            }
        }
    }
}