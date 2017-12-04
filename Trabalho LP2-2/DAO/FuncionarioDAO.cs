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
    class FuncionarioDAO
    {
        private int keyCliente;


        public void Create(Funcionario c)
        {
            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO funcionario(Nome, Cpf, Rg, Telefone, email, datanasc, ecivil, salario, cep, rua, bairro, numero, complemento, nomebanco, agencia, nconta, login, senha) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}',  '{13}', '{14}', '{15}', '{16}', '{17}');",
                c.Nome, c.Cpf, c.Rg, c.Telefone, c.Email, c.Datanasc, c.Ecivil, c.SalarioBase, c.Cep, c.Rua, c.Bairro, c.Numero, c.Complemento, c.NomeBanco, c.Agencia, c.Nconta, c.Login, c.Senha);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            KeyCliente = int.Parse(dr["LAST_INSERT_ID()"].ToString());
        }

        public Funcionario Read(int key)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM funcionario WHERE id =" + key;
            DataSet ds = db.ExecuteQuery(qry);
            Funcionario c = new Funcionario();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Id = int.Parse(dr["id"].ToString());
            c.Nome = dr["Nome"].ToString();
            c.Cpf = dr["Cpf"].ToString();
            c.Telefone = dr["Telefone"].ToString();
            c.Rg = dr["rg"].ToString();
            c.Email = dr["email"].ToString();
            c.Datanasc = dr["datanasc"].ToString();
            c.Ecivil = dr["ecivil"].ToString();
            c.SalarioBase = Double.Parse(dr["salario"].ToString());
            c.Cep = dr["cep"].ToString();
            c.Rua = dr["rua"].ToString();
            c.Bairro = dr["bairro"].ToString();
            c.Numero = dr["numero"].ToString();
            c.Complemento = dr["complemento"].ToString();
            c.NomeBanco = dr["nomebanco"].ToString();
            c.Agencia = dr["agencia"].ToString();
            c.Nconta = dr["nconta"].ToString();
            c.Removido = int.Parse(dr["removido"].ToString());
            c.Login = dr["login"].ToString();
            c.Senha = dr["senha"].ToString();

            return c;
        }

        public void Update(Funcionario c)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE funcionario SET Nome = '{0}', Cpf = '{1}', Rg = '{2}', Telefone = '{3}', email = '{4}', datanasc = '{5}', ecivil = '{6}', salario = '{7}', cep = '{8}', rua = '{9}', bairro = '{10}', numero = '{11}', complemento = '{12}', nomebanco = '{13}', agencia = '{14}', nconta = '{15}', login = '{16}', senha = '{17}' WHERE Id ={18}",
                c.Nome, c.Cpf, c.Rg, c.Telefone, c.Email, c.Datanasc, c.Ecivil, c.SalarioBase, c.Cep, c.Rua, c.Bairro, c.Numero, c.Complemento, c.NomeBanco, c.Agencia, c.Nconta, c.Login, c.Senha, c.Id);
            db.ExecuteNonQuery(qry);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();

            string qry = String.Format("UPDATE funcionario  SET removido = 1 WHERE Id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public void DeleteNull(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM funcionario WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public List<Funcionario> ListAll()
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM funcionario";
            DataSet ds = db.ExecuteQuery(qry);

            List<Funcionario> lc = new List<Funcionario>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Funcionario c = new Funcionario();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["Nome"].ToString();
                c.Cpf = dr["Cpf"].ToString();
                c.Telefone = dr["Telefone"].ToString();
                c.Rg = dr["rg"].ToString();
                c.Email = dr["email"].ToString();
                c.Datanasc = dr["datanasc"].ToString();
                c.Ecivil = dr["ecivil"].ToString();
                c.SalarioBase = Double.Parse(dr["salario"].ToString());
                c.Cep = dr["cep"].ToString();
                c.Rua = dr["rua"].ToString();
                c.Bairro = dr["bairro"].ToString();
                c.Numero = dr["numero"].ToString();
                c.Complemento = dr["complemento"].ToString();
                c.NomeBanco = dr["nomebanco"].ToString();
                c.Agencia = dr["agencia"].ToString();
                c.Nconta = dr["nconta"].ToString();
                c.Removido = int.Parse(dr["removido"].ToString());
                c.Login = dr["login"].ToString();
                c.Senha = dr["senha"].ToString();

                
                lc.Add(c);
            }

            return lc;
        }

        public List<Funcionario> ListByName(string nome)
        {
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM Funcionario WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Funcionario> lc = new List<Funcionario>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Funcionario c = new Funcionario();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["Nome"].ToString();
                c.Cpf = dr["Cpf"].ToString();
                c.Telefone = dr["Telefone"].ToString();
                c.Rg = dr["rg"].ToString();
                c.Email = dr["email"].ToString();
                c.Datanasc = dr["datanasc"].ToString();
                c.Ecivil = dr["ecivil"].ToString();
                c.SalarioBase = Double.Parse(dr["salario"].ToString());
                c.Cep = dr["cep"].ToString();
                c.Rua = dr["rua"].ToString();
                c.Bairro = dr["bairro"].ToString();
                c.Numero = dr["numero"].ToString();
                c.Complemento = dr["complemento"].ToString();
                c.NomeBanco = dr["nomebanco"].ToString();
                c.Agencia = dr["agencia"].ToString();
                c.Nconta = dr["nconta"].ToString();
                c.Removido = int.Parse(dr["removido"].ToString());
                c.Login = dr["login"].ToString();
                c.Senha = dr["senha"].ToString();

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
