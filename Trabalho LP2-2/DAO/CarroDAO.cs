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

    public class CarroDAO
    {
        private int keyCliente;

        

        public void Create(Carro c)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO carro(nome, modelo, precobase) VALUES('{0}', '{1}', '{2}');", c.Nome, c.Modelo, c.PrecoBase);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            KeyCliente = int.Parse(dr["LAST_INSERT_ID()"].ToString());


            foreach(Motor m in c.Motor)
            { 
                qry = String.Format("INSERT INTO carromotor(idcarro, idmotor) VALUES('{0}', '{1}');", KeyCliente, m.Id);
                dbConcessionaria.ExecuteNonQuery(qry);
            }

            foreach (Opcional o in c.Opcional)
            {
                qry = String.Format("INSERT INTO carroopcional(idcarro, idopcional) VALUES('{0}', '{1}');", KeyCliente, o.Id);
                dbConcessionaria.ExecuteNonQuery(qry);
            }


        }

        public Carro Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT * FROM carro WHERE Id = " + key);
            DataSet ds = db.ExecuteQuery(qry);
            Carro c = new Carro();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Id = int.Parse(dr["id"].ToString());
            c.Nome = dr["nome"].ToString();
            c.Modelo = dr["modelo"].ToString();
            c.PrecoBase = double.Parse(dr["precobase"].ToString());
            c.Removido = int.Parse(dr["removido"].ToString());

            
            //junta carro com motor
            int id;
            MotorDAO motor = new MotorDAO();
            qry = String.Format("SELECT m.id, m.nome, m.ano, m.cavalos, m.litragem, m.preco, m.removido FROM carro c JOIN carromotor cm ON c.id = cm.idcarro JOIN motor m ON cm.idmotor = m.id WHERE c.id ={0}", key);
           ds = db.ExecuteQuery(qry);
            
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
                c.Motor.Add(m);
            }
            
           //junta carro com opcionais
           qry = "SELECT o.id, o.nome, o.ano, o.itens, o.preco, o.removido FROM carro c JOIN carroOpcional co ON c.id = co.idcarro JOIN opcional o ON co.idopcional = o.id WHERE c.id = " + key;
            ds = db.ExecuteQuery(qry);

            

            foreach (DataRow dropcional in ds.Tables[0].Rows)
            {
                Opcional o = new Opcional();
                o.Id = int.Parse(dropcional["Id"].ToString());
                o.Nome = dropcional["nome"].ToString();
                o.Ano = dropcional["ano"].ToString();
                o.Itens = dropcional["itens"].ToString();
                o.Preco = double.Parse(dropcional["preco"].ToString());
                o.Removido = int.Parse(dropcional["removido"].ToString());
                c.Opcional.Add(o);
            }
            





            return c;
        }

        public void Update(Carro c)
        {
            Database db = Database.GetInstance();

            string qry = String.Format("UPDATE carro SET nome = '{0}', modelo = '{1}', precobase = '{2}' WHERE Id = '{3}'", c.Nome, c.Modelo, c.PrecoBase, c.Id);
            db.ExecuteNonQuery(qry);
            
            CarroOpcionalDAO co = new CarroOpcionalDAO();
            CarroMotorDAO cm = new CarroMotorDAO();
            Console.WriteLine("o id eh " + c.Id);
            co.Delete(c.Id);
            cm.Delete(c.Id);

            foreach (Opcional o in c.Opcional)
                co.Create(c.Id, o.Id);

            foreach (Motor m in c.Motor)
                cm.Create(c.Id, m.Id);

        }

        public void Delete(int key) { 
        
            Database db = Database.GetInstance();
            
            string qry = qry = String.Format("UPDATE carro SET removido = 1 WHERE Id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public void DeleteNull(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM carro WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public List<Carro> ListAll()
        {
            CarroMotorDAO cm = new CarroMotorDAO();
            CarroOpcionalDAO co = new CarroOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carro";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carro> lc = new List<Carro>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carro c = new Carro();
                c.Id = int.Parse(dr["Id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.PrecoBase = double.Parse(dr["precobase"].ToString());
                c.Removido = int.Parse(dr["removido"].ToString());

                c.Motor = cm.Read(c.Id);
                c.Opcional = co.Read(c.Id);

                lc.Add(c);
            }

            
            return lc;
        }



        public List<Carro> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carros WHERE nome LIKE '%" + nome+ "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carro> lc = new List<Carro>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carro c = new Carro();
                c.Id = int.Parse(dr["Id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.PrecoBase = double.Parse(dr["precobase"].ToString());
                c.Removido = int.Parse(dr["removido"].ToString());

                lc.Add(c);
            }

            return lc;
        }



        public int KeyCliente
        {
            get
            {
                return keyCliente;
            }

            set
            {
                keyCliente = value;
            }
        }


    }
}
