namespace MAUIResizingIssue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

     void OnButtonClicked(object sender, EventArgs args)
    {
		mainLabel.Text += mainLabel.Text;
    }

}

