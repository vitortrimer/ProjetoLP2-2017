using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabalho_LP2_2
{
    class OpcionalDAO
    {

        private int keymotores;



        public void Create(Opcional o)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO Opcional(nome, itens, ano, preco) VALUES('{0}', '{1}', '{2}', '{3}');", o.Nome, o.Itens, o.Ano, o.Preco);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            Keymotores = int.Parse(dr["LAST_INSERT_ID()"].ToString());

        }

        public Opcional Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT * FROM Opcional WHERE id = {0}", key);
            DataSet ds = db.ExecuteQuery(qry);
            Opcional o = new Opcional();

            DataRow dr = ds.Tables[0].Rows[0];
            o.Id = int.Parse(dr["id"].ToString());
            o.Nome = dr["nome"].ToString();
            o.Itens = dr["itens"].ToString();
            o.Ano = dr["ano"].ToString();
            o.Preco = double.Parse(dr["preco"].ToString());
            o.Removido = int.Parse(dr["removido"].ToString());

            return o;
        }

        public void Update(Opcional o)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE opcional SET nome = '{0}', itens = '{1}', ano = '{2}', preco = '{3}' WHERE id = {4}", o.Nome, o.Itens, o.Ano, o.Preco, o.Id);
            db.ExecuteNonQuery(qry);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE opcional SET removido = 1 WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public void DeleteNull(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM opcional WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public List<Opcional> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT* FROM opcional";
            DataSet ds = db.ExecuteQuery(qry);

            List<Opcional> lo = new List<Opcional>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Opcional o = new Opcional();
                o.Id = int.Parse(dr["id"].ToString());
                o.Nome = dr["nome"].ToString();
                o.Itens = dr["itens"].ToString();
                o.Preco = double.Parse(dr["preco"].ToString());
                o.Removido = int.Parse(dr["removido"].ToString());

                lo.Add(o);
            }

            return lo;
        }

        public List<Opcional> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM opcional WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Opcional> lo = new List<Opcional>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Opcional o = new Opcional();
                o.Id = int.Parse(dr["id"].ToString());
                o.Nome = dr["nome"].ToString();
                o.Itens = dr["itens"].ToString();
                o.Preco = double.Parse(dr["preco"].ToString());
                o.Removido = int.Parse(dr["removido"].ToString());

                lo.Add(o);
            }


            return lo;
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
