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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoVendas editVenda = new frmEdicaoVendas();
                        editVenda.VendasRow = carSelect;
                        editVenda.ShowDialog();

                        this.vendasTableAdapter.Update(editVenda.VendasRow);

                    }
                    break;
                case 1:
                    {
                        
                    }
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            addVenda formAdd = new addVenda();
            formAdd.ShowDialog();
            this.vendasTableAdapter.Insert(
                formAdd.vendasRow.Carro,
                formAdd.vendasRow.Quantidade,
                formAdd.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
        }
    }
}
