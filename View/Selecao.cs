using SpanZapForms.Acesso;
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
    public partial class Selecao : Form
    {
        public Selecao()
        {
            InitializeComponent();
        }
        public int Id { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Selecao_Load(object sender, EventArgs e)
        {
            CampanhaDB metodos = new CampanhaDB();
            DGV.DataSource = metodos.Select();
            DGV.Columns[0].Width = 100;
            DGV.Columns[1].Width = 270;
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            var obj = (DataGridView)sender;
            int linha = obj.SelectedRows.Count;
            if (linha>0)
            {
                Id = int.Parse(obj.SelectedRows[0].Cells[0].Value.ToString());
                nomeCamp.Text = obj.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void BtnRodar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                Rodar tela = new Rodar();
                this.Hide();
                tela.ID = Id;
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma campanha foi selecionada.");
            }
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {
            var t = FindForm();
            t.Close();
        }
    }
}
