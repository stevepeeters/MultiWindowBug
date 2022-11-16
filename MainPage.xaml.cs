namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnOpenWindowClicked(object sender, EventArgs e)
	{
		ContentPage dummyPage = new()
		{
			Content = new Label() { Text = "Dummy Label", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }
		};
		Window secondWindow = new(dummyPage);
		Application.Current.OpenWindow(secondWindow);
	}

	private async void OnDisplayAlertClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Alert", "Hello World.", "OK");
	}
}

