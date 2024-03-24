namespace FirstMauiApp.Pages;

public partial class DemoContentPage1 : ContentPage
{
	public DemoContentPage1()
	{
		InitializeComponent();
	}

    private async void pageBasicFlash_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoContentPage2());
    }

    private async void pageInterFlash_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoContentPage3());
    }
}