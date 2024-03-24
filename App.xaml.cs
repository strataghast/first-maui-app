using FirstMauiApp.Pages;
using FirstMauiApp.Pages.FlyoutPageDemo;
using FirstMauiApp.Pages.NavPageDemo;
using FirstMauiApp.Pages.TabbedPageDemo;

namespace FirstMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navigationPage = new NavigationPage(new NavContentPage1());
            ////MainPage = new DemoContentPage1(); // Change this line to the page you want to test
            //navigationPage.BarBackgroundColor = Color.FromArgb("#7B7C7F"); // Set the background color of the navigation bar
            //navigationPage.BarTextColor = Color.FromArgb("#999889"); // Set the text color of the navigation bar
            //MainPage = navigationPage; // NavigationPage is a container for pages that can be navigated to and from
            ////provides a back button to navigate back to the previous page
            

            ////MainPage = new DemoFlyoutPage(); // Change this line to the page you want to test
            MainPage = new DemoTabPage(); // Change this line to the page you want to test
            
        }
    }
}
