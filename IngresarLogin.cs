using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTAS
{
    public partial class IngresarLogin : Form
    {
        public IngresarLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 Log1 = new Form1();
            this.Hide();
            Log1.ShowDialog();
            this.Close();


        }

        public string id = "emma";
        public string clave = "qwert";

        private void IngresarLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
