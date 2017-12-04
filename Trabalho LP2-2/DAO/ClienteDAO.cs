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
    public class ClienteDAO
    {
        private int keyCliente;

     
        public void Create(Cliente c)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO cliente(Nome, Cpf, Rg, Telefone, email, datanasc, ecivil, renda, cep, rua, bairro, numero, complemento, nomebanco, agencia, nconta) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}',  '{13}', '{14}', '{15}');",
                c.Nome, c.Cpf, c.Rg, c.Telefone, c.Email, c.Datanasc, c.Ecivil, c.Renda, c.Cep, c.Rua, c.Bairro, c.Numero, c.Complemento, c.NomeBanco, c.Agencia, c.Nconta);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            KeyCliente = int.Parse(dr["LAST_INSERT_ID()"].ToString());
        }

        public Cliente Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM cliente WHERE id =" + key;
            DataSet ds = db.ExecuteQuery(qry);
            Cliente c = new Cliente();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Id = int.Parse(dr["id"].ToString());
            c.Nome = dr["Nome"].ToString();
            c.Cpf = dr["Cpf"].ToString();
            c.Telefone = dr["Telefone"].ToString();
            c.Rg = dr["rg"].ToString();
            c.Email = dr["email"].ToString();
            c.Datanasc = dr["datanasc"].ToString();
            c.Ecivil = dr["ecivil"].ToString();
            c.Renda = Double.Parse(dr["renda"].ToString());
            c.Cep = dr["cep"].ToString();
            c.Rua = dr["rua"].ToString();
            c.Bairro = dr["bairro"].ToString();
            c.Numero = dr["numero"].ToString();
            c.Complemento = dr["complemento"].ToString();
            c.NomeBanco = dr["nomebanco"].ToString();
            c.Agencia = dr["agencia"].ToString();
            c.Nconta = dr["nconta"].ToString();
            c.Removido = int.Parse(dr["removido"].ToString());

            return c;
        }

        public void Update(Cliente c)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE cliente SET Nome = '{0}', Cpf = '{1}', Rg = '{2}', Telefone = '{3}', email = '{4}', datanasc = '{5}', ecivil = '{6}', renda = '{7}', cep = '{8}', rua = '{9}', bairro = '{10}', numero = '{11}', complemento = '{12}', nomebanco = '{13}', agencia = '{14}', nconta = '{15}' WHERE Id ={16}",
                c.Nome, c.Cpf, c.Rg, c.Telefone, c.Email, c.Datanasc, c.Ecivil, c.Renda, c.Cep, c.Rua, c.Bairro, c.Numero, c.Complemento, c.NomeBanco, c.Agencia, c.Nconta, c.Id);
            db.ExecuteNonQuery(qry);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();

            string qry = String.Format("UPDATE cliente  SET removido = 1 WHERE Id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public void DeleteNull(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM cliente WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public List<Cliente> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM cliente";
            DataSet ds = db.ExecuteQuery(qry);

            List<Cliente> lc = new List<Cliente>();
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = new Cliente();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["Nome"].ToString();
                c.Cpf = dr["Cpf"].ToString();
                c.Telefone = dr["Telefone"].ToString();
                c.Rg = dr["rg"].ToString();
                c.Email = dr["email"].ToString();
                c.Datanasc = dr["datanasc"].ToString();
                c.Ecivil = dr["ecivil"].ToString();
                c.Renda = Double.Parse(dr["renda"].ToString());
                c.Cep = dr["cep"].ToString();
                c.Rua = dr["rua"].ToString();
                c.Bairro = dr["bairro"].ToString();
                c.Numero = dr["numero"].ToString();
                c.Complemento = dr["complemento"].ToString();
                c.NomeBanco = dr["nomebanco"].ToString();
                c.Agencia = dr["agencia"].ToString();
                c.Nconta = dr["nconta"].ToString();
                c.Removido = int.Parse(dr["removido"].ToString());


                lc.Add(c);
            }
            
            return lc;
        }

        public List<Cliente> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM cliente WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Cliente> lc = new List<Cliente>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = new Cliente();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["Nome"].ToString();
                c.Cpf = dr["Cpf"].ToString();
                c.Telefone = dr["Telefone"].ToString();
                c.Rg = dr["rg"].ToString();
                c.Email = dr["email"].ToString();
                c.Datanasc = dr["datanasc"].ToString();
                c.Ecivil = dr["ecivil"].ToString();
                c.Renda = Double.Parse(dr["renda"].ToString());
                c.Cep = dr["cep"].ToString();
                c.Rua = dr["rua"].ToString();
                c.Bairro = dr["bairro"].ToString();
                c.Numero = dr["numero"].ToString();
                c.Complemento = dr["complemento"].ToString();
                c.NomeBanco = dr["nomebanco"].ToString();
                c.Agencia = dr["agencia"].ToString();
                c.Nconta = dr["nconta"].ToString();
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
