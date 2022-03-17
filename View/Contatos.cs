using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpanZapForms.Acesso;
using SpanZapForms.Model;
using SpanZapForms.View;
using System.IO;
using ClosedXML.Excel;
using System.Reflection;
using System.Threading;

namespace SpanZapForms.View
{
    public partial class Contatos : Form
    {
        public Contatos()
        {
            InitializeComponent();
        }
        Thread tt;
        public int Id { get; set; }
        public string NomeCamp { get; set; }

        private void Contatos_Load(object sender, EventArgs e)
        {
            NomeCampanha.Text = NomeCamp;
            ContatosDB metodos = new ContatosDB();
            DGVContatos.DataSource = metodos.Select(Id);
            DGVContatos.Columns[1].Width = 320;
            DGVContatos.Columns[2].Width = 130;
        }

        private void BtnISalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtINome.Text) || string.IsNullOrEmpty(TxtIFone.Text)) { MessageBox.Show("Preencha os Campos com o nome e o telefone do contato"); }
            else {
                SpanZapForms.Model.Contatos Model = new Model.Contatos();
                ContatosDB metodos = new ContatosDB();
                Model.Nome = TxtINome.Text;
                Model.fone = TxtIFone.Text;
                Model.CampanhaId = Id;
                if (metodos.Insert(Model) != true)
                {
                    MessageBox.Show("Algo deu errado!");
                }
                else
                {
                    MessageBox.Show("Inserido com Sucesso !");
                    DGVContatos.DataSource = metodos.Select(Id);
                    TxtINome.Text="";
                    TxtIFone.Text="";
                }

            }
        }


        //Não remover passivle de bugs
        private void DGVContatos_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void DGVContatos_SelectionChanged_1(object sender, EventArgs e)
        {
            var obj = (DataGridView)sender;
            int linha = obj.SelectedRows.Count;

            if (linha > 0)
            {
                int id = int.Parse(obj.SelectedRows[0].Cells[0].Value.ToString());
                ContatosDB metodos = new ContatosDB();
                SpanZapForms.Model.Contatos model = new Model.Contatos();
                model = metodos.SelectId(id);

                TxtENome.Text = model.Nome;
                TxtEFone.Text = model.fone;
                TxtEId.Text = model.Id.ToString();
            }
        }

        //Update Contato
        private void BtnEAltera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtENome.Text) || string.IsNullOrEmpty(TxtEFone.Text)) { MessageBox.Show("Preencha os Campos com o nome e o telefone do contato"); }
            else
            {
                SpanZapForms.Model.Contatos model = new Model.Contatos();
                model.Id = int.Parse(TxtEId.Text);
                model.Nome = TxtENome.Text;
                model.fone = TxtEFone.Text;
                model.CampanhaId = Id;
                ContatosDB metodos = new ContatosDB();

                if (metodos.Update(model)!=true) { MessageBox.Show("Algo deu errado! Observe atentamente os campos ('NOME','TELEFONE') e tente novamente"); }
                else
                {
                    MessageBox.Show("Alterado Com Sucesso!");
                    DGVContatos.DataSource = metodos.Select(Id);
                }
            }
        }

        // Deleta o contato
        private void BtnEDell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtENome.Text) || string.IsNullOrEmpty(TxtEFone.Text)) { MessageBox.Show("Preencha os Campos com o nome e o telefone do contato"); }
            else
            {
                
               int id = int.Parse(TxtEId.Text);
                
                ContatosDB metodos = new ContatosDB();

                if (metodos.Delete(id) != true) { MessageBox.Show("Algo deu errado! Observe atentamente os campos ('NOME','TELEFONE') e tente novamente"); }
                else
                {
                    MessageBox.Show("Removido Com Sucesso!");
                    DGVContatos.DataSource = metodos.Select(Id);
                }
            }
        }

        // Inserir contatos em massa 
        private void BtnIMassa_Click(object sender, EventArgs e)
        {
            Lista.ShowDialog();

            string caminho = Lista.FileName;

            if (string.IsNullOrEmpty(caminho))
            {
                MessageBox.Show("Preciso que você selecione a planilha com os contatos");
            }
            else
            {

                try
                {
                    PBLoad.Visible = true;
                    PGBcarregar.Visible = true;
                    PGBcarregar.Minimum = 0;


                    ContatosDB metodos = new ContatosDB();
                    var xls = new XLWorkbook(caminho);


                    var planilha = xls.Worksheet("SheetJs");
                    var linhas = planilha.Rows().Count();


                    int contador = 0;
                    PGBcarregar.Maximum = linhas;
                    for (int i = 2; i <= linhas; i++)
                    {
                        contador = contador + 1;
                        string nome = planilha.Cell($"B{i}").Value.ToString();
                        string numero = planilha.Cell($"C{i}").Value.ToString();
                        var nCerto = numero.Replace("+55", "");
                        //if (nCerto.Length == 11)
                        //{
                            if (string.IsNullOrEmpty(nome)) { nome = "Contato Sem Nome"; }
                            SpanZapForms.Model.Contatos contato = new Model.Contatos();
                            contato.Nome = nome;
                            contato.fone = nCerto;
                            contato.CampanhaId = Id;
                            if(
                            metodos.Insert(contato) != true)
                            {
                                MessageBox.Show("Este Contato " + contato.fone.ToString() + " não pode ser inserido, tente inserir ele manualmente mais tarde");
                            }
                       // }
                        PGBcarregar.Value = contador;
                    }
               
                    MessageBox.Show("Cadastrados");
                    DGVContatos.DataSource = metodos.Select(Id);
                }
                catch { MessageBox.Show("Primerio Verifique se o a planilha não está aberta em um oltro programa, se estiver feche ela primeiro!"); }
                PBLoad.Visible = false;
                PGBcarregar.Visible = false;
            }

            //tt = new Thread(new ThreadStart(InserirMassa));
            //tt.SetApartmentState(ApartmentState.STA);
            //tt.IsBackground = true;
            //tt.Start();

        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {
            var j = FindForm();
            j.Close();
        }


        // o tal do delegate 
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        private void SetControlPropertyValue(Control oControl, string propName, object propValue)

        {

            if (oControl.InvokeRequired)

            {

                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);

                oControl.Invoke(d, new object[] { oControl, propName, propValue });

            }

            else

            {

                Type t = oControl.GetType();

                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)

                {

                    if (p.Name.ToUpper() == propName.ToUpper())

                    {

                        p.SetValue(oControl, propValue, null);

                    }

                }

            }

        }


        //Metodos de Inserir em massa 
        private void InserirMassa()
        {
            OpenFileDialog Listat = new OpenFileDialog();
            Listat.ShowDialog();
          

            string caminho = Listat.FileName;
            if (string.IsNullOrEmpty(caminho))
            {
                MessageBox.Show("Preciso que você selecione a planilha com os contatos");
            }
            else
            {
                
                SetControlPropertyValue(PBLoad, "Visible", true);
                SetControlPropertyValue(PGBcarregar, "Visible", true);
                ContatosDB metodos = new ContatosDB();
                var xls = new XLWorkbook(caminho);
               
             

                var planilha = xls.Worksheet("SheetJs");
                var linhas = planilha.Rows().Count();
                
              
                int contador = 0;
                SetControlPropertyValue(PGBcarregar, "Minimun", 0);
                SetControlPropertyValue(PGBcarregar, "Maximum", linhas);

                for (int i = 2; i < linhas; i++)
                {
                    string nome="";
                    contador = contador + 1;
                    try { nome = planilha.Cell($"B{i}").Value.ToString(); } catch
                    {
                        nome = "";
                    }
                    //string nome = planilha.Cell($"B{i}").Value.ToString();
                    string numero = planilha.Cell($"C{i}").Value.ToString();
                    if (string.IsNullOrEmpty(numero)) { numero = "00000000000"; }
                    var nCerto = numero.Replace("+55", "");

                    //if (string.IsNullOrEmpty(nome))
                    //{
                    //    nome = "Contato Sem Nome"; 
                    //}
                    SpanZapForms.Model.Contatos contato = new Model.Contatos();
                    contato.Nome = nome;
                    contato.fone = nCerto;
                    contato.CampanhaId = Id;
                   if(metodos.Insert(contato) != true)
                    {
                        MessageBox.Show("Este Contato " + contato.fone.ToString() + " não pode ser inserido, tente inserir ele manualmente mais tarde");
                    }
                    
                    SetControlPropertyValue(PGBcarregar, "Value", contador);
                    // catch { MessageBox.Show("Este Contato "+contato.fone.ToString()+" não pode ser inserido, tente inserir ele manualmente mais tarde"); }
                }

                if (linhas == contador) {
                    if (tt.IsAlive == true)
                    {
                        tt.Abort();
                        SetControlPropertyValue(PBLoad, "Visible", false);
                        SetControlPropertyValue(PGBcarregar, "Visible", false);
                    }
                }
            }
        }

        //cuidado passivel de zica no código
        private void BtnPlanilha_Click(object sender, EventArgs e)
        {

        }

        private void Planilha_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog janela = new FolderBrowserDialog();
            janela.RootFolder = Environment.SpecialFolder.MyComputer;
            janela.ShowNewFolderButton = true;
            janela.Description = "Escolha um caminho de destino";

            string origemPasta = System.Environment.CurrentDirectory;
            string origenArquivo = origemPasta + @"\Assets\MinhaLista.xlsx";
          
            if (janela.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoDestino = janela.SelectedPath;
                    var destino = Path.Combine(caminhoDestino, "AguiarBot Modelo Lista Importação.xlsx");
                    File.Copy(origenArquivo, destino, true);
                    MessageBox.Show($"'Baixado' Com sucesso!");
                }
                catch(Exception px)
                {
                    var zica = px.ToString();
                    MessageBox.Show(zica);
                }
            }
        }

        private void BtnExcluirVarios_Click(object sender, EventArgs e)
        {
            ExlcuirMassa form = new ExlcuirMassa();
            form.Id = Id;
            form.ShowDialog();
        }

        private void BtnAtualizarDGV_Click(object sender, EventArgs e)
        {
            ContatosDB metodos = new ContatosDB();
            DGVContatos.DataSource = metodos.Select(Id);
        }
    }
}
