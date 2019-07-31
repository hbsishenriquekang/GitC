using CadastroCarro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCarro
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        public AdicionarCarro novoCarro = new AdicionarCarro();
        private void TelaDeCadastro_Load(object sender, EventArgs e)
        {
            novoCarro.Modelo = tbxModelo.Text;
            novoCarro.Ano = (int)nrAno.Value;
            novoCarro.Placa = tbxPlaca.Text;

            this.Close();
        }
    }
}
