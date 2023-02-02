namespace museumApp;

public partial class InterestsQuiz : ContentPage
{
	public InterestsQuiz()
	{
		InitializeComponent();
	}

	RadioButton colorBtn;
	bool selected = false;

	private void checkChange(Object sender, System.EventArgs e)
	{
		RadioButton button= sender as RadioButton;
		if (button.IsChecked && button.GroupName == "colors")
		{
			colorBtn = button;
			selected = true;
		}
	}

	public void submitQuiz(object sender, EventArgs e)
    {
		if (selected)
		{
			successLabel.Text = "Submitted!";
			Preferences.Set("favColor", colorBtn.ContentAsString());
		} else
		{
            successLabel.Text = "Fail!";
        }
	}
}