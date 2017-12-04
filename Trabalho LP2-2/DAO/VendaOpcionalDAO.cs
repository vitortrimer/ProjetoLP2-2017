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
    class VendaOpcionalDAO
    {



        public List<Opcional> Read(int key)
        {
            OpcionalDAO motor = new OpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT o.id, o.nome, o.ano, o.itens, o.preco, o.removido FROM venda v JOIN vendaOpcionais vo ON v.id = vo.idvenda JOIN opcional o ON vo.idopcional = o.id WHERE v.id = " + key;
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
    }
}
