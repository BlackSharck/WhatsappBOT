using SpanZapForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SpanZapForms.Acesso
{
   public class CampanhaDB
    {
        public static string direct = System.Environment.CurrentDirectory;
        private readonly string Caminho = @"Data Source=" + direct + @"\Assets\Banco\SpanZap.db";
        //string Caminho = @"C\Banco\SpanZap.db";
        public bool insert(Campanha model)
        {
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            string action = $"Insert into Campanha (nome,saudaUm,saudaDois,conteudo) values('{model.Nome}','{model.SaudaUM}','{model.SaudaDois}','{model.TxtCampanha}')";
            SQLiteCommand command = new SQLiteCommand(action,Sql);

            try {
                Sql.Open();
                command.ExecuteNonQuery();
            } catch
            {
                return false;
            }
            finally
            {
                Sql.Close();
            }
            return true;
        }
       
        public List<Campanha> Select()
        {
            List<Campanha> Model = new List<Campanha>();

            string action = "select * from Campanha";
            SQLiteConnection sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action,sql);

            try {
                sql.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campanha campanha = new Campanha();
                    campanha.Id = int.Parse(reader["id"].ToString());
                    campanha.Nome = reader["nome"].ToString();
                    campanha.SaudaUM = reader["saudaUm"].ToString();
                    campanha.SaudaDois = reader["saudaDois"].ToString();
                    campanha.TxtCampanha = reader["conteudo"].ToString();
                    Model.Add(campanha);
                }

            } catch { } finally { sql.Close(); }

            return Model;
        }

        public Campanha SelectId( int id)
        {
            Campanha Model = new Campanha();

            string action = $"select * from Campanha where id ={id}";
            SQLiteConnection sql = new SQLiteConnection(Caminho);
            SQLiteCommand command = new SQLiteCommand(action, sql);

            try
            {
                sql.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    Model.Id = int.Parse(reader["id"].ToString());
                    Model.Nome = reader["nome"].ToString();
                    Model.SaudaUM = reader["saudaUm"].ToString();
                    Model.SaudaDois = reader["saudaDois"].ToString();
                    Model.TxtCampanha = reader["conteudo"].ToString();
                   
                }

            }
            catch { }
            finally { sql.Close(); }

            return Model;
        }

        public bool Update(Campanha model)
        {
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            string action = $"UPDATE Campanha SET nome='{model.Nome}',saudaUM='{model.SaudaUM}',saudaDois='{model.SaudaDois}',conteudo='{model.TxtCampanha}' WHERE id = {model.Id}";
            SQLiteCommand command = new SQLiteCommand(action, Sql);

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                Sql.Close();
            }
            return true;
            
        }

        public bool Delete(int id)
        {
            SQLiteConnection Sql = new SQLiteConnection(Caminho);
            string action = $"DELETE FROM Campanha WHERE id = {id}";
            SQLiteCommand command = new SQLiteCommand(action, Sql);

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                Sql.Close();
            }
            return true;
           
        }

        
    }
}
