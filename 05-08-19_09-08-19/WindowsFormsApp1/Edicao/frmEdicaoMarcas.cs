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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }
        public WindowsFormsApp1.QuerysInnerJoinDataSet.MarcasRow MarcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            textBox1.Text = MarcasRow.Nome;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome = textBox1.Text;
            
            this.Close();
        }
    }
}
