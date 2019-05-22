using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressora3D
{
    public partial class ListaDocs : Form
    {
        public ListaDocs()
        {
            InitializeComponent();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PastaInicial = txtPastaInicial.Text;
            Properties.Settings.Default.PadraoArquivos = cboPadraoArquivos.Text;
            Properties.Settings.Default.Save();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtPastaInicial.Text = Properties.Settings.Default.PastaInicial;
            cboPadraoArquivos.Text = Properties.Settings.Default.PadraoArquivos;
        }


        private void btnLocalizar_Click(object sender, EventArgs e)        
        {
            if (!string.IsNullOrEmpty(txtPastaInicial.Text) && cboPadraoArquivos.SelectedIndex != -1)
            {
                ProcuraArquivos(lblArquivos, txtPastaInicial.Text, cboPadraoArquivos.Text);
            }
            else
            {
                MessageBox.Show("Defina a pasta incial de busca e/ou o padrão de arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnDirectorioInicial_Click(object sender, EventArgs e)
        {
            try
            {
                fbd1.SelectedPath = txtPastaInicial.Text;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    txtPastaInicial.Text = fbd1.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
        }



        private void ProcuraArquivos(ListBox lstb, string pastaInicial, string padrao)
        {
            try
            {

                lblArquivos.Items.Clear();

                string[] padroes = AnalisaPadroes(padrao);
                DirectoryInfo dir_info = new DirectoryInfo(pastaInicial);

                ProcuraDiretorio(lstb, dir_info, padroes);

                MessageBox.Show("Foram encontrados " + lstb.Items.Count + " arquivos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string[] AnalisaPadroes(string string_padrao)
        {
            try
            {

                if (string_padrao.Contains("("))
                {
                    string_padrao = TextoEntre(string_padrao, "(", ")");
                }

                string[] resultado = string_padrao.Split(';');
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = resultado[i].Trim();
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private string TextoEntre(string txt, string delimitador1, string delimitador2)
        {
            try
            {
                int pos1 = txt.IndexOf(delimitador1);
                int texto_inicio = pos1 + delimitador1.Length;
                int pos2 = txt.IndexOf(delimitador2, texto_inicio);
                return txt.Substring(texto_inicio, pos2 - texto_inicio);
            }
            catch
            {
                throw;
            }
        }


        private void ProcuraDiretorio(ListBox lstb, DirectoryInfo dir_info, string[] padroes)
        {
            try
            {
                foreach (string padrao in padroes)
                {
                    foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    {
                        ProcessaArquivo(lstb, Arq_info);
                    }
                }
                foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
                {
                    ProcuraDiretorio(lstb, subdir_info, padroes);
                }
            }
            catch
            {
                throw;
            }
        }


        private void ProcessaArquivo(ListBox lstb, FileInfo arq_info)
        {
            try
            {
                lstb.Items.Add(arq_info.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Projetos();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
