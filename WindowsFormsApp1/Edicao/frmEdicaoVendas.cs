using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public WindowsFormsApp1.QuerysInnerJoinDataSet.VendasRow VendasRow;
        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
            
            comboBox1.SelectedValue = VendasRow.Carro;
            nrQuantidade.Value = VendasRow.Quantidade;
            textBox1.Text = VendasRow.Valor.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)comboBox1.SelectedValue;
            VendasRow.Quantidade = (int)nrQuantidade.Value;
            VendasRow.Valor = decimal.Parse(textBox1.Text);

        }
    }
}
