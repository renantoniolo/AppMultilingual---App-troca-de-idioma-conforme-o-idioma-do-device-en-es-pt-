using System.Collections.Generic;
using System.Globalization;

using Plugin.Multilingual;
using Xamarin.Forms;

namespace AppMultilingual
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;

            MainPage =  new NavigationPage(new LoginViewPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
