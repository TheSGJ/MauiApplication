namespace MyMauiApplication;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
                Title = "";
                NavigationPage.SetHasNavigationBar(this, false);
                ToolbarItems.Clear();
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void Teleport_Button(object sender, EventArgs e)
	{
		DisplayAlert("You are teleported Home! 🏠 ", "Sugoi 💫💻", "OK");
	}
}

