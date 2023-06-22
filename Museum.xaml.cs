using Microsoft.Maui.Controls;

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

    private void outputFromMd(string md, VerticalStackLayout viewParent)
    {
        foreach (var paragraph in md.Split("\n\n")) {
            Element element;
            var content = paragraph.Trim();
            content = content.Trim('\n');
            if (content.StartsWith('#'))
            {
                element = new Label { Text = content.Trim('#'), FontSize=32 };
                SemanticProperties.SetHeadingLevel(element, SemanticHeadingLevel.Level2);
            } else if (content.StartsWith('!'))
            {
                element = new HorizontalStackLayout();
                string[] imageStrings = content.TrimStart('!').Split(':');
                Image image = new() { Source = imageStrings[0] };
                SemanticProperties.SetDescription(image, imageStrings[1]);
                (element as HorizontalStackLayout).Add(image);
            } else 
            {
                element = new Label { Text = content };
            }
            viewParent.Add((IView)element);
        }
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
        h1.Text = splitList[0];
        Title = splitList[0];
        outputFromMd(splitList[1], main);
        outputFromMd(splitList[2], details);
    }
}