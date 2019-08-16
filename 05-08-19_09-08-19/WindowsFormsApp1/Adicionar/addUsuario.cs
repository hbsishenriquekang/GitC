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
    public partial class addUsuario : Form
    {
        public addUsuario()
        {
            InitializeComponent();
        }
        public User usuarioRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow = new User
            {
                Usuario = textBox1.Text,

            };
            this.Close();
        }
    }
}
