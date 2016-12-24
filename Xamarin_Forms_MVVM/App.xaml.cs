using Xamarin.Forms;
using Xamarin_Forms_MVVM.View;

namespace Xamarin_Forms_MVVM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MyName());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
 
