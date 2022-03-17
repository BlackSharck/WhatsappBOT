using SpanZapForms.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanZapForms.Acesso
{
    public class ContatosDB
    {
        public static string direct = System.Environment.CurrentDirectory;
        private readonly string Caminho = @"Data Source=" + direct + @"\Assets\Banco\SpanZap.db";
        //string Caminho = @"C\Banco\SpanZap.db";

        public bool Insert(Contatos model ) {
            if (string.IsNullOrEmpty(model.Nome)) { model.Nome = "Contato sem nome público"; }
            string action = $"INSERT into Contatos (nome,numero,campId) VALUES ('{model.Nome}','{model.fone}',{model.CampanhaId})";
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action,Sql);

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
            }
            catch { 
                return false; 
            }
            finally { Sql.Close(); }
            return true; 
        }


        public bool Delete(int id) {
            string action = $"DELETE FROM Contatos WHERE id ={id}";
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action, Sql);

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
            }
            catch { return false; }
            finally { Sql.Close(); }
            return true;
        }


        public bool Update(Contatos model) {
            string action = $"UPDATE Contatos SET nome='{model.Nome}' , numero ='{model.fone}', campId ={model.CampanhaId} WHERE id = {model.Id}";
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action, Sql);

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
            }
            catch { return false; }
            finally { Sql.Close(); }
            return true;
        }


        public List<Contatos> Select (int CampanhaId)
        {
            List<Contatos> Model = new List<Contatos>();

            string action = $"select * from Contatos where campId={CampanhaId}";
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            SQLiteCommand comand = new SQLiteCommand(action,Sql);
            try
            {
                Sql.Open();
                SQLiteDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Contatos contato = new Contatos();
                    contato.Id = int.Parse(reader["id"].ToString());
                    contato.Nome = reader["nome"].ToString();
                    contato.fone= reader["numero"].ToString();
                    contato.CampanhaId= int.Parse(reader["campId"].ToString());
                    Model.Add(contato); 
                }

            }
            catch(Exception E) { MessageBox.Show(E.ToString()); }
            finally { Sql.Close(); }

            return Model;


        }

        public Contatos SelectId(int id)
        {
            Contatos contato = new Contatos();

            string action = $"select * from Contatos where id ={id}";
            SQLiteConnection sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action, sql);

            try
            {
                sql.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    contato.Id = int.Parse(reader["id"].ToString());
                    contato.Nome = reader["nome"].ToString();
                    contato.fone = reader["numero"].ToString();
                    contato.CampanhaId = int.Parse(reader["campId"].ToString());
                    
                }

            }
            catch { }
            finally { sql.Close(); }

            return contato;


        }
    }
}
