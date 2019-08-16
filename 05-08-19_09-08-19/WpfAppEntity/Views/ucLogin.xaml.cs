using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interação lógica para ucLogin.xam
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public event EventHandler success;
        public event EventHandler fail;
        public BibliotecaDBContext context = new BibliotecaDBContext();
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var nomeUsuario = tbxUsuario.Text;
            var nomeSenha = tbxSenha.Password;

            var result = context.Bibliotecas.FirstOrDefault(x => x.Login == nomeUsuario && x.Senha == nomeSenha);

            if(result?.Id > 0)
            {
                success("Usuario logado sucesso!", new EventArgs());
            }
            else
            {
                fail($"Falha ao logar com usuário {tbxUsuario}.", new EventArgs());
            }
        }
    }
}
