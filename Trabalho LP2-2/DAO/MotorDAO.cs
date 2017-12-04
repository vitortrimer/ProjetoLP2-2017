using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Trabalho_LP2_2
{
    public class MotorDAO
    {
        private int keymotores;

        

        public void Create(Motor m)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO Motor(nome, litragem, ano, cavalos, preco) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", m.Nome, m.Litragem, m.Ano, m.Cavalos, m.PrecoBase);
            dbConcessionaria.ExecuteNonQuery(qry);
            
            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            Keymotores = int.Parse(dr["LAST_INSERT_ID()"].ToString());
            
        }

        public Motor Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT * FROM motor WHERE id = {0}", key);
            DataSet ds = db.ExecuteQuery(qry);
            Motor m = new Motor();

            DataRow dr = ds.Tables[0].Rows[0];
            m.Id = int.Parse(dr["id"].ToString());
            m.Nome = dr["nome"].ToString();
            m.Litragem = dr["litragem"].ToString();
            m.Ano = dr["ano"].ToString();
            m.Cavalos = dr["cavalos"].ToString();
            m.PrecoBase = double.Parse(dr["preco"].ToString());
            m.Removido = int.Parse(dr["removido"].ToString());

            return m;
        }

        public void Update(Motor m)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE motor SET nome = '{0}', litragem = '{1}', ano = '{2}', cavalos = '{3}', preco = '{4}'  WHERE id ={5}", m.Nome, m.Litragem, m.Ano, m.Cavalos, m.PrecoBase, m.Id);
            db.ExecuteNonQuery(qry);
            
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE motor SET removido = 1 WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public void DeleteNull(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM motor WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public List<Motor> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT* FROM motor";
            DataSet ds = db.ExecuteQuery(qry);

            List<Motor> lc = new List<Motor>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Motor m = new Motor();
                m.Id = int.Parse(dr["id"].ToString());
                m.Nome = dr["nome"].ToString();
                m.Litragem = dr["litragem"].ToString();
                m.Ano = dr["ano"].ToString();
                m.Cavalos = dr["cavalos"].ToString();
                m.PrecoBase = double.Parse(dr["preco"].ToString());
                m.Removido = int.Parse(dr["removido"].ToString());

                lc.Add(m);
            }

            return lc;
        }

        public List<Motor> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM motor WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Motor> lm = new List<Motor>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Motor m = new Motor();
                m.Id = int.Parse(dr["id"].ToString());
                m.Nome = dr["nome"].ToString();
                m.Litragem = dr["litragem"].ToString();
                m.Ano = dr["ano"].ToString();
                m.Cavalos = dr["cavalos"].ToString();
                m.PrecoBase = double.Parse(dr["preco"].ToString());
                m.Removido = int.Parse(dr["removido"].ToString());

                lm.Add(m);
            }
           

            return lm;
        }
        
        

        public int Keymotores
        {
            get
            {
                return keymotores;
            }

            set
            {
                keymotores = value;
            }
        }


    }
}
