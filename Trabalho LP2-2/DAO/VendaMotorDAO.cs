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
    class VendaMotorDAO
    {
        public List<Motor> Read(int key)
        {
            MotorDAO motor = new MotorDAO();
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT m.id, m.nome, m.ano, m.cavalos, m.litragem, m.preco, m.removido FROM venda v JOIN vendamotor vm ON v.id = vm.idvenda JOIN motor m ON vm.idmotor = m.id WHERE v.id ={0}", key);
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

    }
}
