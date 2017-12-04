using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;


namespace Trabalho_LP2_2
{
    class CarroOpcionalDAO
    {

        public void Create(int keycarro, int keyopcional)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO carroOpcional(idcarro, idopcional) VALUES('{0}', '{1}');", keycarro, keyopcional);
            dbConcessionaria.ExecuteNonQuery(qry);
        }


        public List<Opcional> Read(int key)
        {
            OpcionalDAO motor = new OpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT o.id, o.nome, o.ano, o.itens, o.preco, o.removido FROM carro c JOIN carroOpcional co ON c.id = co.idcarro JOIN opcional o ON co.idopcional = o.id WHERE c.id = " + key;
            DataSet ds = db.ExecuteQuery(qry);

            List<Opcional> lo = new List<Opcional>();


            foreach (DataRow dropcional in ds.Tables[0].Rows)
            {
                Opcional o = new Opcional();
                o.Id = int.Parse(dropcional["Id"].ToString());
                o.Nome = dropcional["nome"].ToString();
                o.Ano = dropcional["ano"].ToString();
                o.Itens = dropcional["itens"].ToString();
                o.Preco = double.Parse(dropcional["preco"].ToString());
                o.Removido = int.Parse(dropcional["removido"].ToString());
                lo.Add(o);
            }

            return lo;
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM carroOpcional WHERE idcarro ={0};", key);
            db.ExecuteNonQuery(qry);
        }


    }
}
