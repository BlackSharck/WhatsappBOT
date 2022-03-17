using SpanZapForms.Acesso;
using SpanZapForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanZapForms.View
{
    public partial class CadCampanha : Form
    {
        public CadCampanha()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtNomecamp.Text) || string.IsNullOrEmpty(TxtSaudaDois.Text) || string.IsNullOrEmpty(TxtSaudaUm.Text) || string.IsNullOrEmpty(txtMensagem.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos antes de salvar esta campanha!.");

            }
            else
            {
                Campanha Model = new Campanha();
                CampanhaDB metodos = new CampanhaDB();

                Model.Nome = TxtNomecamp.Text;
                Model.SaudaUM = TxtSaudaUm.Text;
                Model.SaudaDois = TxtSaudaDois.Text;
                Model.TxtCampanha = txtMensagem.Text;

                if (metodos.insert(Model) != true)
                {
                    MessageBox.Show("Algo Deu Errado ! Observe os campos e tente novamente");
                }
                else
                {
                    MessageBox.Show("Cadastrado com Sucesso!");
                    this.FindForm().Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tela = FindForm();
            tela.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
