namespace museumApp;

public partial class Museum : ContentPage
{
    private const int DEFAULT_TEXT_SIZE = 18;
    readonly Shared shared = new();
	public Museum()
	{
		InitializeComponent();
        LoadAsset();
	}

    private void moreDetailsClicked(object sender, EventArgs e)
    {
		expandButton.IsVisible	= false;
		details.IsVisible = true;
    }

    private static void outputFromMd(string md, VerticalStackLayout viewParent)
    {
        foreach (var paragraph in md.Split("\n\n")) {
            Element element;
            var content = paragraph.Trim();
            content = content.Trim('\n');
            if (content.Length < 2) continue;
            switch (content[0])
            {
                case '#':
                    var fontSize = 30;
                    var heading =SemanticHeadingLevel.Level2;
                    if (content[1] == '#')
                    {
                        fontSize = 25;
                        heading = SemanticHeadingLevel.Level3;
                    }
                    element = new Label { Text = content.Trim('#'), FontSize=fontSize };
                    SemanticProperties.SetHeadingLevel(element, heading);
                    break;
                case '!':
                    element = new VerticalStackLayout();
                    var child = new HorizontalStackLayout();
                    string[] imageStrings = content.TrimStart('!').Split(':');
                    Image image = new() { Source = imageStrings[0] };
                    SemanticProperties.SetDescription(image, imageStrings[1]);
                    child.Add(image);
                    (element as VerticalStackLayout).Add(child);
                    (element as VerticalStackLayout).Add(new Label {Text= imageStrings[1], FontSize= DEFAULT_TEXT_SIZE });
                    break;
                case '?':
                    string[] strings = content.TrimStart('?').Split('?');
                    element = new Hyperlink { Url = strings[0], Text = strings[1].Trim(), FontSize = DEFAULT_TEXT_SIZE };
                    break;
                default:
                    element = new Label { Text = content, FontSize=DEFAULT_TEXT_SIZE };
                    break;
            }
            viewParent.Add((IView)element);
        }
    }

    async void LoadAsset()
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
