namespace FirstMauiApp.Pages;

public partial class DemoContentPage2 : ContentPage
{
	public DemoContentPage2()
	{
		InitializeComponent();
	}

    private async void pageDecks_Clicked(object sender, EventArgs e)
    {
		// Instead of PushModalAsync, use PopModalAsync to go back to the previous page (prevents creating multiple instances of the same page)
		// Creating multiple instances of the same page can cause memory leaks
		await Navigation.PopModalAsync();
    }
}