using app.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace app
{
    public partial class App : Application
    {
        //VERIFICAR CONEXION    //////////////////////////////////
        //public PhoneBookPage LoginPage { get; }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
           // LoginPage = new PhoneBookPage();
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
