using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginFatecNovo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegida : ContentPage
    {
        public Protegida()
        {
            InitializeComponent();

            string usuario = App.Current.Properties["PersistenciaUsuarioLogado"].ToString();

            lbl_saudacao.Text = "Bem-vindo (a) " + usuario;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool confirmacao = await DisplayAlert("Tem Certeza?", "Vai sair do Sistema?", "Sim", "Não");

                if(confirmacao)
                {
                    if (App.Current.Properties.Remove("PersistenciaUsuarioLogado"))
                        App.Current.MainPage = new Login();
                    else
                        throw new Exception("Falha ao remover a chave de persistência");
                }

                Console.WriteLine("AQUI ----------------------------------------------------------------");
                Console.WriteLine(App.Current.Properties.ContainsKey("PersistenciaUsuarioLogado"));

            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}