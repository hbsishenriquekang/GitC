using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFCadastro
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            string telefone = Telefone.Text;
            string email = Email.Text;

            var stringRegTelefone = @"^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$";
            var stringRegEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Regex regextelefone = new Regex(stringRegTelefone);
            Regex regexemail = new Regex(stringRegEmail);

            var matchtelefone = regextelefone.IsMatch(telefone);
            var matchemail = regexemail.IsMatch(email);


            if (matchtelefone)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("Not Nice");
            }
            if(matchemail)
            {
                Console.WriteLine("belo email");
            }
            else
            {
                Console.WriteLine("cria um email novo ai fera");
            }
            
            
            
        }
    }
}
