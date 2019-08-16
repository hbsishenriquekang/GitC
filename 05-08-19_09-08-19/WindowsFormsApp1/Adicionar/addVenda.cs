using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Adicionar
{
    public partial class addVenda : Form
    {
        public addVenda()
        {
            InitializeComponent();
        }

        private void AddVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);

        }
        public Venda vendasRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            vendasRow = new Venda
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = decimal.Parse(textBox1.Text),


            };
            this.Close();
        }
    }
}
