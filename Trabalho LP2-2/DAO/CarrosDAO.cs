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
    public class CarrosDAO
    {
        private MotoresDAO motor = new MotoresDAO();
        private int keyCarro;


        public void Create(Carros c)
        {
            int key;
            Database dbConcessionaria = Database.GetInstance();
            Motor.Create(c);
            key = Motor.Keymotores;
            string qry = String.Format("INSERT INTO carros(nome, modelo, idMotores, TetoSolar, Multimidia, Ligaleve, PAdicional) VALUES('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}');", c.Nome, c.Modelo, key, c.TetoSolar, c.Multimidia, c.LigaLeve, c.PAdicional);
            dbConcessionaria.ExecuteNonQuery(qry);
            
        }

        public Carros Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carros c JOIN Motores m ON c.idMotores = m.id WHERE c.Cod =" + key;
            DataSet ds = db.ExecuteQuery(qry);
            Carros c = new Carros();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Cod = int.Parse(dr["Cod"].ToString());
            c.Nome = dr["nome"].ToString();
            c.Modelo = dr["modelo"].ToString();
            //c.Motor.Id = int.Parse(dr["idMotores"].ToString());
            c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
            c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
            c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
            c.PAdicional = double.Parse(dr["PAdicional"].ToString());
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

            string qry = String.Format("UPDATE carros SET nome = '{0}', modelo = '{1}', TetoSolar = {2}, Multimidia = {3}, LigaLeve = {4}, PAdicional = {5} WHERE Cod = {6}", c.Nome, c.Modelo, c.TetoSolar, c.Multimidia,c.LigaLeve, c.PAdicional, c.Cod);
            db.ExecuteNonQuery(qry);
           // Motor.Update(c);
            
            //qry = String.Format("UPDATE carros SET M10 = {0}, P10 = {1}, M10T = {2}, P10T = {3}, M13 = {4}, P13 = {5}, M16 = {6}, P16 = {7}, M20 = {8}, P20 = {9}, M20T = {10}, P20T = {11}, WHERE idMotores = {12}", c.Motor.M10, c.Motor.P10, c.Motor.M10t, c.Motor.P10t, c.Motor.M13, c.Motor.P13, c.Motor.M16, c.Motor.P16, c.Motor.M20, c.Motor.P20, c.Motor.M20t, c.Motor.P20t, c.Motor.Id);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT idMotores FROM carros WHERE cod = {0}", key);
            DataSet ds = db.ExecuteQuery(qry);
            int keymotor;
            DataRow dr = ds.Tables[0].Rows[0];
            keymotor = int.Parse(dr["idMotores"].ToString());
            motor.Delete(keymotor);
            qry = String.Format("DELETE FROM carros WHERE Cod = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public List<Carros> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carros c JOIN Motores m ON c.idMotores = m.id";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Cod = int.Parse(dr["Cod"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Motor.Id = int.Parse(dr["idMotores"].ToString());
                c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
                c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
                c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
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
                c.PAdicional = double.Parse(dr["PAdicional"].ToString());

                lc.Add(c);
            }

            return lc;
        }

        public List<Carros> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carros c JOIN Motores m ON c.idMotores = m.id WHERE c.nome LIKE '%" + nome+ "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Cod = int.Parse(dr["Cod"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Motor.Id = int.Parse(dr["idMotores"].ToString());
                c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
                c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
                c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
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
                c.PAdicional = double.Parse(dr["PAdicional"].ToString());

                lc.Add(c);
            }

            return lc;
        }

        public MotoresDAO Motor
        {
            get
            {
                return motor;
            }

            set
            {
                motor = value;
            }
        }


    }
}
