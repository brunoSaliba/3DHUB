using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressora3D
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            textBox2.Text = "";
 
            textBox2.PasswordChar = '*';

            textBox2.MaxLength = 14;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ListaDocs();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
