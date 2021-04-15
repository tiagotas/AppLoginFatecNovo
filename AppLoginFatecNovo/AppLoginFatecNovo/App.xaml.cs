using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginFatecNovo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Console.WriteLine(Properties.ContainsKey("PersistenciaUsuarioLogado"));

            if(Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {
                MainPage = new Protegida();

            } else
            {
                MainPage = new Login();
            }
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
