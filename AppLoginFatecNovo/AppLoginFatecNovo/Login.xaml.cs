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
    public partial class Login : ContentPage
    {
        string usuario_correto = "aluno";
        string senha_correta = "123";

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario_digitado = txt_usuario.Text;
                string senha_digitada = txt_senha.Text;

                if (usuario_digitado == usuario_correto && senha_digitada == senha_correta)
                {
                    App.Current.Properties.Add("PersistenciaUsuarioLogado", usuario_digitado);

                    App.Current.MainPage = new Protegida();
                }
                else
                    throw new Exception("Usuário ou senha incorretos.");

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}