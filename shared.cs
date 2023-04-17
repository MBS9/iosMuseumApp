namespace museumApp
{
    public class Shared
    {
        public string pageSymbol = "page";
        public async void clickHandler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // TODO: This design is not orthogonal - fix this
            Preferences.Set(this.pageSymbol, button.Text.ToLower().Replace(" ", "_"));
            await Shell.Current.GoToAsync("exampleMuseum");
        }
    }
}

