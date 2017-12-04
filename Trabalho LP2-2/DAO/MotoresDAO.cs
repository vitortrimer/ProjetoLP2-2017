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
    public class MotoresDAO
    {
        private int keymotores;

        

        public void Create(Carros c)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO Motores(M10, P10, M10T, P10T, M13, P13, M16, P16, M20, P20, M20T, P20T) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11});", c.Motor.M10, c.Motor.P10, c.Motor.M10t, c.Motor.P10t, c.Motor.M13, c.Motor.P13, c.Motor.M16, c.Motor.P16, c.Motor.M20, c.Motor.P20, c.Motor.M20t, c.Motor.P20t);
            dbConcessionaria.ExecuteNonQuery(qry);
            
            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            Keymotores = int.Parse(dr["LAST_INSERT_ID()"].ToString());
            
        }

        public Carros Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT * FROM motores WHERE id = {0}", key);
            DataSet ds = db.ExecuteQuery(qry);
            Carros c = new Carros();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Motor.Id = int.Parse(dr["id"].ToString());
            c.Motor.M10 = bool.Parse(dr["M10"].ToString());
            c.Motor.P10 = double.Parse(dr["P10"].ToString());
            c.Motor.M10t = bool.Parse(dr["M10T"].ToString());
            c.Motor.P10t = double.Parse(dr["P10T"].ToString());
            c.Motor.M13 = bool.Parse(dr["M13"].ToString());
            c.Motor.P13 = double.Parse(dr["P13"].ToString());
            c.Motor.M16 = bool.Parse(dr["M16"].ToString());
            c.Motor.P16 = double.Parse(dr["P16"].ToString());
            c.Motor.M20 = bool.Parse(dr["M20"].ToString());
            c.Motor.P20 = double.Parse(dr["P20"].ToString());
            c.Motor.M20t = bool.Parse(dr["M20T"].ToString());
            c.Motor.P20t = double.Parse(dr["P20T"].ToString());

            return c;
        }

        public void Update(Carros c)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE motores SET M10 = {0}, P10 = {1}, M10T = {2}, P10T = {3}, M13 = {4}, P13 = {5}, M16 = {6}, P16 = {7}, M20 = {8}, P20 = {9}, M20T = {10}, P20T = {11} WHERE id = {12}", c.Motor.M10, c.Motor.P10, c.Motor.M10t, c.Motor.P10t, c.Motor.M13, c.Motor.P13, c.Motor.M16, c.Motor.P16, c.Motor.M20, c.Motor.P20, c.Motor.M20t, c.Motor.P20t, c.Motor.Id);
            db.ExecuteNonQuery(qry);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM motores WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        /*
        public List<Carros> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT* FROM carros c JOIN motores m WHERE c.idmotores = m.id;";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Motor.Id = int.Parse(dr["id"].ToString());
                c.Motor.M10 = bool.Parse(dr["M10"].ToString());
                c.Motor.P10 = double.Parse(dr["P10"].ToString());
                c.Motor.M10t = bool.Parse(dr["M10T"].ToString());
                c.Motor.P10t = double.Parse(dr["P10T"].ToString());
                c.Motor.M13 = bool.Parse(dr["M13"].ToString());
                c.Motor.P13 = double.Parse(dr["P13"].ToString());
                c.Motor.M16 = bool.Parse(dr["M16"].ToString());
                c.Motor.P16 = double.Parse(dr["P16"].ToString());
                c.Motor.M20 = bool.Parse(dr["M20"].ToString());
                c.Motor.P20 = double.Parse(dr["P20"].ToString());
                c.Motor.M20t = bool.Parse(dr["M20T"].ToString());
                c.Motor.P20t = double.Parse(dr["P20T"].ToString());

                lc.Add(c);
            }

            return lc;
        }

        public List<Carros> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM clientes WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Cod = int.Parse(dr["Cod"].ToString());
                c.Nome = dr["Nome"].ToString();
                c.Modelo = dr["Modelo"].ToString();
                c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
                c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
                c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
                c.Motor.Id = int.Parse(dr["idMotores"].ToString());
                c.Motor.M10 = bool.Parse(dr["M10"].ToString());
                c.Motor.P10 = double.Parse(dr["P10"].ToString());
                c.Motor.M10t = bool.Parse(dr["M10t"].ToString());
                c.Motor.P10t = double.Parse(dr["P10t"].ToString());
                c.Motor.M13 = bool.Parse(dr["M13"].ToString());
                c.Motor.P13 = double.Parse(dr["P13"].ToString());
                c.Motor.M16 = bool.Parse(dr["M16"].ToString());
                c.Motor.P16 = double.Parse(dr["P16"].ToString());
                c.Motor.M20 = bool.Parse(dr["M20"].ToString());
                c.Motor.P20 = double.Parse(dr["P20"].ToString());
                c.Motor.M20t = bool.Parse(dr["M20t"].ToString());
                c.Motor.P20t = double.Parse(dr["P20t"].ToString());

                lc.Add(c);
            }
           

            return lc;
        }
        
        */

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
