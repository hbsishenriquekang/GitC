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
    public partial class frmEdicaoCarros : Form
    {
        public frmEdicaoCarros()
        {
            InitializeComponent();
        }

        public WindowsFormsApp1.QuerysInnerJoinDataSet.CarrosRow CarrosRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet.Marcas);
            textBox1.Text = CarrosRow.Modelo;
            dateTimePicker1.Value = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;
        }

        

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = textBox1.Text;
            CarrosRow.Ano = dateTimePicker1.Value;
            CarrosRow.Marca = (int)comboBox1.SelectedValue;

            this.Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
