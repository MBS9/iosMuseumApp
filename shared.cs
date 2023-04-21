namespace museumApp
{
    public class Shared
    {
        public string pageSymbol = "page";
        public async void clickHandler(object sender, EventArgs e)
        {
            /*
            Handles click events which aim to navigate to a museum page. Will determine the museum from the button's text.
             */
            Button button = sender as Button;
            // TODO: This design is not orthogonal - fix this
            Preferences.Set(this.pageSymbol, button.Text.ToLower().Replace(" ", "_"));
            await Shell.Current.GoToAsync("museum");
        }
    }
}
