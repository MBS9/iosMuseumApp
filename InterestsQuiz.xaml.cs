namespace museumApp;

public partial class InterestsQuiz : ContentPage
{
	public InterestsQuiz()
	{
		InitializeComponent();
	}

	public void submitQuiz(object sender, EventArgs e)
    {
		successLabel.Text = "Submitted!";
	}
}