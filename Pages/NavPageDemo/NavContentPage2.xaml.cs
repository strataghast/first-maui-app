namespace FirstMauiApp.Pages.NavPageDemo;

public partial class NavContentPage2 : ContentPage
{
	public NavContentPage2()
	{
		InitializeComponent();
	}

    private async void navContentPage1Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}