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
    class CarroMotorDAO
    {

        public void Create(int keycarro, int keymotor)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO carromotor(idcarro, idmotor) VALUES('{0}', '{1}');", keycarro, keymotor);
            dbConcessionaria.ExecuteNonQuery(qry);
        }


        public List<Motor> Read(int key)
        {
            MotorDAO motor = new MotorDAO();
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT m.id, m.nome, m.ano, m.cavalos, m.litragem, m.preco, m.removido FROM carro c JOIN carromotor cm ON c.id = cm.idcarro JOIN motor m ON cm.idmotor = m.id WHERE c.id ={0}", key);
            DataSet ds = db.ExecuteQuery(qry);

            List<Motor> lm = new List<Motor>();

            foreach (DataRow drmotor in ds.Tables[0].Rows)
            {
                Motor m = new Motor();
                m.Id = int.Parse(drmotor["Id"].ToString());
                m.Nome = drmotor["nome"].ToString();
                m.Ano = drmotor["ano"].ToString();
                m.Cavalos = drmotor["cavalos"].ToString();
                m.Litragem = drmotor["Litragem"].ToString();
                m.PrecoBase = double.Parse(drmotor["preco"].ToString());
                m.Removido = int.Parse(drmotor["removido"].ToString());
                lm.Add(m);
            }

            return lm;
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM carromotor WHERE idcarro = {0};", key);
            db.ExecuteNonQuery(qry);
        }

    }
}
