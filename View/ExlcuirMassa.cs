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
    public partial class ExlcuirMassa : Form
    {
        public ExlcuirMassa()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var k = FindForm();
            k.Close();
        }

        private void ExlcuirMassa_Load(object sender, EventArgs e)
        {
            ContatosDB metodos = new ContatosDB();
            DGVContatos2.DataSource = metodos.Select(Id);
            if (DGVContatos2.Rows.Count > 0)
            {
                DGVContatos2.SelectedRows[0].Selected = false;
            }
            DGVContatos2.Columns[1].Width = 178;
            DGVContatos2.Columns[2].Width = 130;
            DGVContatos2.Columns[0].Width = 30;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContatosDB metodos = new ContatosDB();

            int linhas = DGVContatos2.SelectedRows.Count;
            List<int> ids = new List<int>();
            if (linhas > 0)
            {
                for (int f = 0; f < linhas; f++)
                {
                    try
                    {
                        ids.Add(int.Parse(DGVContatos2.SelectedRows[f].Cells[0].Value.ToString()));
                    }
                    catch
                    {

                    }
                }
                
            }
            else
            {
                MessageBox.Show("Nenhum contato foi selecionado.");
            }
            if (ids.Count > 0)
            {
                foreach (var i in ids)
                {
                    metodos.Delete(int.Parse(i.ToString()));
                }
            }
           
            DGVContatos2.DataSource = metodos.Select(Id);
            if (DGVContatos2.Rows.Count > 0)
            {
                DGVContatos2.SelectedRows[0].Selected = false;
            }
           
            MessageBox.Show($"{ids.Count} contatos excluidos");


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
