using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LixeiraCarro : Form
    {
        public LixeiraCarro()
        {
            InitializeComponent();
        }

        private void LixeiraCarro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomInativeValues(this.querysInnerJoinDataSet.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                var carUpdate = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                    as QuerysInnerJoinDataSet.CarrosRow;

                
                        
                this.carrosTableAdapter.RestoreQuery(carUpdate.Id);
                        
                        

                this.carrosTableAdapter.CustomInativeValues(this.querysInnerJoinDataSet.Carros);
            }
        }
    }
}
