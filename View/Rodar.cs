using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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
using System.Threading;
using System.Reflection;

namespace SpanZapForms.View
{
    public partial class Rodar : Form
    {

        Thread tt;
        public Rodar()
        {
            InitializeComponent();
            Timer.Interval = 3000;
            //Timer.Tick += timer1_Tick;
        }
        public int ID { get; set; }
        CampanhaDB MetodosCampanha = new CampanhaDB();
        ContatosDB MetodosContatos = new ContatosDB();

        Campanha ModelCampanha = new Campanha();
        List<Model.Contatos> ModelContatos = new List<Model.Contatos>();

     

        private void Rodar_Load(object sender, EventArgs e)
        {
            //ModelContatos = MetodosContatos.Select(ModelCampanha.Id);
            
            //Barra.Minimum = 0;
            //int quantiab = ModelContatos.Count();
            //quantiab = quantiab + 1;
            //Barra.Maximum =quantiab ;
            //Timer.Start();
          
            tt = new Thread(new ThreadStart(rodar));
            tt.IsBackground = true;
            tt.Start();
            //new Thread(rodar).Start(Barra);
        }

        private void Rodar_Shown(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //new Thread().Start(rodar(Barra));
            Timer.Stop();

        }
   
       private void rodar()
        {
            ModelCampanha = MetodosCampanha.SelectId(ID);
            ModelContatos = MetodosContatos.Select(ModelCampanha.Id);
            int quantiab = ModelContatos.Count();
            quantiab = quantiab + 1;
            //ModelCampanha = MetodosCampanha.SelectId(ID);
            //ModelContatos = MetodosContatos.Select(ModelCampanha.Id);
            // Config Barra
            //this.Barra.Minimum = 0;
            //this.Barra.Maximum = ModelContatos.Count() + 1;
            //this.Barra.Step = 1;

            // Config textos
            string sauda1 = ModelCampanha.SaudaUM;
            string sauda2 = ModelCampanha.SaudaDois;
            string SMS = ModelCampanha.TxtCampanha;

            if (ModelContatos.Count() < 1)
            {
                MessageBox.Show("Esta Campanha ainda não possui contatos!");
                var telas = FindForm();
                telas.Close();
            }
            if (sauda1 == null) { sauda1 = "Olá!"; }
            if (sauda2 == null) { sauda2 = "Ei!"; }

            ChromeDriverService srv = ChromeDriverService.CreateDefaultService();
            srv.HideCommandPromptWindow = true;
            ChromeDriver Driver = new ChromeDriver(srv);


            try { Driver.Navigate().GoToUrl("https://web.whatsapp.com/"); } catch { MessageBox.Show("O Navegador não abriu!"); tt.Abort(); }
            //Driver.Navigate().GoToUrl("https://web.whatsapp.com/");
            bool control = false;
            string elemento = null;
            while (control == false)
            {
                try
                {

                    elemento = Driver.FindElement(By.ClassName("_1G3Wr")).ToString();
                }
                catch { }
                if (elemento != null)
                {
                    control = true;
                }
            }
            int tamanhoB = ModelContatos.Count();
            SetControlPropertyValue(Barra, "Minimum", 0);
            SetControlPropertyValue(Barra, "Maximum", tamanhoB);
            int barra=1;




            //começa a brincadeira
            for (int i = 0; i < ModelContatos.Count; i++)
            {
                //configura a barra
                SetControlPropertyValue(Barra, "Minimum", 0);
                SetControlPropertyValue(Barra, "Maximum", quantiab);
                SetControlPropertyValue(Barra, "value", barra);


                //prepara as variaveis 
                Random saudarol = new Random();
                int saudarandom = saudarol.Next(1, 3);
                string Saudacaos = null;
                if (saudarandom < 2) { Saudacaos = sauda1; }
                if (saudarandom > 1) { Saudacaos = sauda2; }

                Thread.Sleep(10000);
                Driver.Navigate().GoToUrl("https://web.whatsapp.com/send?phone=55" + ModelContatos[i].fone);

              
                Thread.Sleep(10000);

                //verifica se o número digitado roda
                bool salta = false;
                for (int f = 0; f<3; f++) {

                    try { var erou = Driver.FindElement(By.ClassName("_3J6wB"));
                        salta = true;
                        break;
                    } 
                    catch { Thread.Sleep(5000); }
                    
                }


                // se o numero rodar inicia o processo
                if (salta == false)
                {
                    control = false;
                    elemento = null;
                    for (int f = 0; f < 4; f++)
                    {
                        try
                        {

                            elemento = Driver.FindElement(By.ClassName("p3_M1")).ToString();
                            break;
                        }
                        catch { Thread.Sleep(15000); }

                    }

                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {
                            var CampoTexto = Driver.FindElement(By.ClassName("p3_M1"));
                            Thread.Sleep(2000);
                            CampoTexto.Click();
                            Thread.Sleep(3000);
                            CampoTexto.SendKeys(Saudacaos);
                            break;
                        }
                        catch { Thread.Sleep(15000); }
                    }
                    //clicar no btn para enviar a saudação 
                    Thread.Sleep(4000);
                    control = false;
                    elemento = null;
                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {

                            elemento = Driver.FindElement(By.ClassName("_4sWnG")).ToString();

                            break;
                        }
                        catch
                        {
                            var CampoTexto = Driver.FindElement(By.ClassName("p3_M1"));
                            Thread.Sleep(2000);
                            CampoTexto.Click();
                            Thread.Sleep(3000);
                            CampoTexto.SendKeys(Saudacaos); 
                            Thread.Sleep(5000);
                        }

                    }
                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {
                            var btn = Driver.FindElement(By.ClassName("_4sWnG"));
                            Thread.Sleep(2000);
                            btn.Click();
                            break;
                        }
                        catch
                        {
                            Thread.Sleep(10000);
                        }
                    }
                    //Digitar mensagem no campo antes de enviar
                    Thread.Sleep(5000);
                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {
                            var CampoTexto = Driver.FindElement(By.ClassName("p3_M1"));
                            Thread.Sleep(2000);
                            CampoTexto.Click();
                            Thread.Sleep(2000);
                            CampoTexto.SendKeys(SMS);
                            break;
                        }
                        catch { Thread.Sleep(10000); }

                    }
                    Thread.Sleep(2000);
                    control = false;
                    elemento = null;
                    //procurando btn de enviar novamente
                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {
                            elemento = Driver.FindElement(By.ClassName("_4sWnG")).ToString();

                            break;
                        }
                        catch { Thread.Sleep(5000); }

                    }
                    Thread.Sleep(2000);
                    for (int f = 0; f < 3; f++)
                    {
                        try
                        {
                            var btn = Driver.FindElement(By.ClassName("_4sWnG"));
                            Thread.Sleep(2000);
                            btn.Click();
                            break;
                        }
                        catch { Thread.Sleep(2000); }

                    }
                }
                    Random lastP = new Random();
                    int pausa = lastP.Next(30000, 50000);

                    barra = barra + 1;
                    int contatos = ModelContatos.Count();
                    contatos = contatos - 1;
                    if (contatos != i) { Thread.Sleep(pausa); }
                

            }
           
            Driver.Close();
            string MSnBtn = "Acabamos! Click para VOLTAR!";
            SetControlPropertyValue(button1, "Text", MSnBtn);
            SetControlPropertyValue(Barra,"value", barra);
            MessageBox.Show("Terminei de Rodar a Campanha " + ModelCampanha.Nome);
            

            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tt.IsAlive == true)
            {
                var yy = FindForm();
                tt.Abort();
                yy.Close();
                
               
            }
            else {
                var yy = FindForm();
             
                yy.Close();
              
               
            }
        }

        private void Rodar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tt.IsAlive==true)
            {
                tt.Abort();
            }
        }
    }
}
