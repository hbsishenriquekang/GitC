
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Adicionar;
using WindowsFormsApp1.Edicao;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomQuerry(this.querysInnerJoinDataSet.Carros);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmVendas = new Form3();
            frmVendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frmUsuarios = new Form4();
            frmUsuarios.ShowDialog();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            LixeiraCarro lxCarro = new LixeiraCarro();
            lxCarro.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as QuerysInnerJoinDataSet.CarrosRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }break;
                case 1:
                    {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        this.carrosTableAdapter.UpdateQuery(
                            editCarro.CarrosRow.Modelo,
                            editCarro.CarrosRow.Ano.ToString(),
                            editCarro.CarrosRow.Marca,
                            editCarro.CarrosRow.UsuAlt,
                            DateTime.Now,
                            editCarro.CarrosRow.Id);
                    }break;

            }
            this.carrosTableAdapter.CustomQuerry(this.querysInnerJoinDataSet.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            addCarro formAdd = new addCarro();
            formAdd.ShowDialog();
            this.carrosTableAdapter.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
        }
    }
}
