namespace FirstMauiApp.Pages.NavPageDemo;

public partial class NavContentPage3 : ContentPage
{
	public NavContentPage3()
	{
		InitializeComponent();
	}

    private async void navContentPage3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}