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
    public partial class addCarro : Form
    {
        public addCarro()
        {
            InitializeComponent();
        }

        public Carro carrosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro
            {
                Modelo = tbxModelo.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue,
            };

        }

        private void AddCarro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);

        }
    }
}
