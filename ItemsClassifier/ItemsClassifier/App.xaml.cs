using Xamarin.Forms;

namespace ItemsClassifier
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.CustomVisionView());
        }
    }
}
