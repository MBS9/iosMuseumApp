using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museumApp
{
    public class Shared
    {
        public Shared() {
        
        }
        public async void clickHandler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // TODO: This design is not orthogonal - fix this
            Preferences.Set("page", button.Text.ToLower().Replace(" ", "_"));
            await Shell.Current.GoToAsync("exampleMuseum");
        }
    }
}
