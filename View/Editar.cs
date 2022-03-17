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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            CampanhaDB metodos = new CampanhaDB();
            List<Campanha> Campanhas = new List<Campanha>();
            Campanhas = metodos.Select();
            DGVCampanhas.DataSource = Campanhas;
            DGVCampanhas.Columns[0].Width = 55;
            DGVCampanhas.Columns[1].Width = 200;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVCampanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //carrega os campos ao selecionar 
        private void DGVCampanhas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView obj = (DataGridView)sender;
            int linha = obj.SelectedRows.Count;

            if (linha>0)
            {
                string id = obj.SelectedRows[0].Cells[0].Value.ToString();
                CampanhaDB metodo = new CampanhaDB();
                Campanha Model = new Campanha();
                Model=metodo.SelectId(int.Parse(id));

                if (Model.Id > 0)
                {
                    TxtId.Text =  Model.Id.ToString();
                    TxtNomeCamp.Text = Model.Nome;
                    TxtSaudaUM.Text = Model.SaudaUM;
                    TxtSaudaDois.Text = Model.SaudaDois;
                    txtTextoCampanha.Text = Model.TxtCampanha;
                }
            }
        }

        //salvar as alterações nas campanhas 
        private void Salvar_Click(object sender, EventArgs e)
        {
            
            CampanhaDB metodos = new CampanhaDB();
            Campanha model = new Campanha();

            if (string.IsNullOrEmpty(TxtId.Text))
            {
                MessageBox.Show("Nenhuma campanha foi selecionada.");
            }
            else
            {
                model.Id = int.Parse(TxtId.Text);
                model.Nome = TxtNomeCamp.Text;
                model.SaudaUM = TxtSaudaUM.Text;
                model.SaudaDois = TxtSaudaDois.Text;
                model.TxtCampanha = txtTextoCampanha.Text;
                if (model.Id > 0)
                {
                    if (metodos.Update(model) != true)
                    {
                        MessageBox.Show("Algo deu errado! Verifique se os campos estão todos preenchidos corretamente.");
                    }
                    else
                    {
                        MessageBox.Show("Alterado Com Sucesso!");
                        List<Campanha> campanhas = new List<Campanha>();
                        campanhas = metodos.Select();
                        DGVCampanhas.DataSource = campanhas;
                    }
                }
            }
        }

        //Exclui a Campanha
        private void BtnDell_Click(object sender, EventArgs e)
        {
            int id=0;
            if (string.IsNullOrEmpty(TxtId.Text))
            {
                MessageBox.Show("Nenhuma campanha foi selecionada.");

            }
            else
            {
                CampanhaDB metodos = new CampanhaDB();
                ContatosDB metodosContatos = new ContatosDB();
                List<SpanZapForms.Model.Contatos> contatos = new List<SpanZapForms.Model.Contatos>();
                contatos = metodosContatos.Select(id);
                id = int.Parse(TxtId.Text);
                if (metodos.Delete(id) != true)
                {
                    MessageBox.Show("Algo deu errado! Verifique atentamente os Campos.");
                }
                else
                {
                    foreach (var i in contatos)
                    {
                        metodosContatos.Delete(i.Id);
                    }
                    MessageBox.Show("Removido Com Sucesso!");
                    List<Campanha> Campanhas = new List<Campanha>();
                    Campanhas = metodos.Select();
                    DGVCampanhas.DataSource = Campanhas;
                }
            }
        }


        //Adiciona Contatos à Campanha
        private void btnAddContato_Click(object sender, EventArgs e)
        {
            try
            {
                Contatos tela = new Contatos();
                tela.Id = int.Parse(TxtId.Text);
                tela.NomeCamp = TxtNomeCamp.Text;
                tela.ShowDialog();
            }
            catch { MessageBox.Show("Nenhuma Campanha selecionada!"); }
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {
            var k = FindForm();
            k.Close();
        }
    }
}
