using TaskAppMaui8.Pages;
namespace TaskAppMaui8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new MainTaskPage());
            MainPage = navigationPage;
        }
    }
}