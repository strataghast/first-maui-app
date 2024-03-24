namespace FirstMauiApp.Pages;

public partial class DemoContentPage3 : ContentPage
{
	public DemoContentPage3()
	{
		InitializeComponent();
	}

    private void pageDecks_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}