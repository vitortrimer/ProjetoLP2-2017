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
    class CarrosVendasDAO
    {
        private MotoresVendaDAO motor = new MotoresVendaDAO();
        private int keyCarro;

        public void Create(Carros c)
        {
            int key;
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO carrosVenda(nome, modelo, TetoSolar, Multimidia, Ligaleve, PAdicional, PTotal, idCarro, motor) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", c.Nome, c.Modelo, c.TetoSolar, c.Multimidia, c.LigaLeve, c.PAdicional, c.PrecoTotal, c.Cod, c.MotorTexto);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            KeyCarro = int.Parse(dr["LAST_INSERT_ID()"].ToString());
        }

        public Carros Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carrosVenda WHERE id =" + key;
            DataSet ds = db.ExecuteQuery(qry);
            Carros c = new Carros();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Cod = int.Parse(dr["Id"].ToString());
            c.Nome = dr["nome"].ToString();
            c.Modelo = dr["modelo"].ToString();
            c.MotorTexto = dr["motor"].ToString();
            c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
            c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
            c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
            c.PAdicional = double.Parse(dr["PAdicional"].ToString());
            c.PrecoTotal = double.Parse(dr["PTotal"].ToString());
            c.Codoriginal = int.Parse(dr["idCarro"].ToString());
            return c;
        }

        public void Update(Carros c)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE carrosVenda SET TetoSolar = '{0}', Multimidia = '{1}', LigaLeve = '{2}', nome = '{3}', modelo = '{4}',  PAdicional = '{5}', PTotal = '{6}', motor = '{7}' WHERE id = {8};", c.TetoSolar, c.Multimidia, c.LigaLeve, c.Nome, c.Modelo, c.PAdicional, c.PrecoTotal, c.MotorTexto, c.Cod);
             db.ExecuteNonQuery(qry);

        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM carrosVenda WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public List<Carros> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carrosVenda";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Cod = int.Parse(dr["Cod"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.MotorTexto = dr["motor"].ToString();
                c.Motor.Id = int.Parse(dr["idMotores"].ToString());
                c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
                c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
                c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
                c.PAdicional = double.Parse(dr["PAdicional"].ToString());
                c.PrecoTotal = double.Parse(dr["PTotal"].ToString());
                c.Codoriginal = int.Parse(dr["idCarro"].ToString());

                lc.Add(c);
            }

            return lc;
        }

        public List<Carros> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM carrosVenda nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Carros> lc = new List<Carros>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Carros c = new Carros();
                c.Cod = int.Parse(dr["Cod"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.MotorTexto = dr["motor"].ToString();
                c.Motor.Id = int.Parse(dr["idMotores"].ToString());
                c.TetoSolar = bool.Parse(dr["TetoSolar"].ToString());
                c.Multimidia = bool.Parse(dr["Multimidia"].ToString());
                c.LigaLeve = bool.Parse(dr["LigaLeve"].ToString());
                c.PAdicional = double.Parse(dr["PAdicional"].ToString());
                c.PrecoTotal = double.Parse(dr["PTotal"].ToString());
                c.Codoriginal = int.Parse(dr["idCarro"].ToString());

                lc.Add(c);
            }

            return lc;
        }

        public MotoresVendaDAO Motor
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

        public int KeyCarro
        {
            get
            {
                return keyCarro;
            }

            set
            {
                keyCarro = value;
            }
        }
    }
}
