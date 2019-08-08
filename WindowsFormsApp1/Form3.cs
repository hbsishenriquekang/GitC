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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as QuerysInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoUsuarios editUsuario = new frmEdicaoUsuarios();
                        editUsuario.UsuariosRow = carSelect;
                        editUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);

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
            addUsuario formAdd = new addUsuario();
            formAdd.ShowDialog();
            this.usuariosTableAdapter.Insert(
                formAdd.usuarioRow.Usuario,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
        }
    }
}
