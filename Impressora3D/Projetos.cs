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
    public partial class Projetos : Form
    {
        public Projetos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte-se a uma impressora valida");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Selecionado com Sucesso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Selecionado com Sucesso");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Selecionado com Sucesso");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Selecionado com Sucesso");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Selecionado com Sucesso");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ListaDocs();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }

}
