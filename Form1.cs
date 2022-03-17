using SpanZapForms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanZapForms
{
    public partial class SpamZap : Form
    {
        public SpamZap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadCampanha Camp = new CadCampanha();
            Camp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selecao janela = new Selecao();
            janela.ShowDialog();
        }
    }
}
