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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarca = new frmEdicaoMarcas();
                        editMarca.MarcasRow = carSelect;
                        editMarca.ShowDialog();

                        this.marcasTableAdapter.UpdateQuery(
                            editMarca.MarcasRow.Nome,
                            editMarca.MarcasRow.UsuAlt,
                            DateTime.Now,
                            editMarca.MarcasRow.Id);
                    }
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addMarca formAdd = new addMarca();
            formAdd.ShowDialog();
            this.marcasTableAdapter.Insert(
                formAdd.marcasRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
        }
    }
}
