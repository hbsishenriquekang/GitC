using CadastroAluno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAluno
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        public Alunos novoAluno = new Alunos();

        private void Sair_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = txbAluno.Text;
            novoAluno.Idade = (int)nrIdade.Value;
            

            this.Close();


        }
    }
}
