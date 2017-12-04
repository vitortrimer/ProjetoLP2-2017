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
    class VendaDAO
    {
        private int keyVenda;
        private ClienteDAO cliente = new ClienteDAO();
        private CarroDAO carro = new CarroDAO();
        private FuncionarioDAO vendedor = new FuncionarioDAO();


        public void Create(Venda v)
        {
            string juros, desconto;
            desconto = "" + v.Desconto;
            juros = "" + v.Juros;
            juros.Replace(",", ".");
            desconto.Replace(",", ".");

            Database dbConcessionaria = Database.GetInstance();
            string qry = String.Format("INSERT INTO venda(idCliente, idVendedor, idCarro, dataVenda, desconto, nParcelas, juros, precoCarro, precoTotal, entrada, restante, valparcela, precoapagar) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');", 
                    v.Cliente.Id, v.Vendedor.Id, v.Carro.Id, v.DataVenda, desconto, v.NParcelas, juros, v.PrecoCarro, v.PrecoTotal, v.Entrada, v.Restante, v.ValParcela, v.PrecoAPAgar);
            dbConcessionaria.ExecuteNonQuery(qry);

            qry = String.Format("SELECT LAST_INSERT_ID();");
            DataSet ds = dbConcessionaria.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            KeyVenda = int.Parse(dr["LAST_INSERT_ID()"].ToString());

            foreach (Motor m in v.Carro.Motor)
            {
                qry = String.Format("INSERT INTO vendamotor(idvenda, idmotor) VALUES('{0}', '{1}');", KeyVenda, m.Id);
                dbConcessionaria.ExecuteNonQuery(qry);
            }

            foreach (Opcional o in v.Carro.Opcional)
            {
                qry = String.Format("INSERT INTO vendaopcionais(idvenda, idopcional) VALUES('{0}', '{1}');", KeyVenda, o.Id);
                dbConcessionaria.ExecuteNonQuery(qry);
            }


        }


        public Venda Read(int key)
        {


            VendaMotorDAO vm = new VendaMotorDAO();
            VendaOpcionalDAO vo = new VendaOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = String.Format("SELECT * FROM venda WHERE id = " + key);
            DataSet ds = db.ExecuteQuery(qry);
            Venda v = new Venda();

            DataRow dr = ds.Tables[0].Rows[0];
            v.Id = int.Parse(dr["id"].ToString());
            v.Cliente.Id = int.Parse(dr["idCliente"].ToString());
            v.Vendedor.Id = int.Parse(dr["idVendedor"].ToString());
            v.Carro.Id = int.Parse(dr["idCarro"].ToString());
            v.DataVenda = dr["dataVenda"].ToString();
            v.Desconto = double.Parse(dr["Desconto"].ToString()); 
            v.NParcelas = int.Parse(dr["nParcelas"].ToString());
            v.Juros = double.Parse(dr["juros"].ToString());
            v.PrecoCarro = double.Parse(dr["precoCarro"].ToString());
            v.PrecoTotal = double.Parse(dr["precoTotal"].ToString());
            v.Entrada = double.Parse(dr["entrada"].ToString());
            v.Restante = double.Parse(dr["restante"].ToString());
            v.ValParcela = double.Parse(dr["valParcela"].ToString());
            v.PrecoAPAgar = double.Parse(dr["PrecoAPagar"].ToString());
            v.IdCliente = int.Parse(dr["idCliente"].ToString());
            v.IdVendedor = int.Parse(dr["idVendedor"].ToString());
            v.IdCarro = int.Parse(dr["idCarro"].ToString());
            v.Removido = int.Parse(dr["removido"].ToString());

            v.Cliente = cliente.Read(v.Cliente.Id);
            v.Carro = carro.Read(v.Carro.Id);
            v.Vendedor = vendedor.Read(v.Vendedor.Id);
            v.Carro.Motor = vm.Read(v.Id);
            v.Carro.Opcional = vo.Read(v.Id);

            return v;
        }

        public void Update(Venda v)
        {
            Database db = Database.GetInstance();

            string qry = String.Format("UPDATE venda SET idCliente = '{0}', idVendedor = '{1}', dataVenda = '{2}', desconto = '{3}', nParcelas = '{4}', juros ='{5}', precoTotal = '{6}', entrada = '{7}' WHERE Id = '{2}'", 
                                    v.Cliente.Id, v.Vendedor.Id, v.DataVenda, v.Desconto, v.NParcelas, v.Juros, v.PrecoTotal, v.Entrada, v.Id);
            db.ExecuteNonQuery(qry);
        }
        
        public void DeleteRemov(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("UPDATE venda SET removido = 1 WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }

        public void Delete(int key)
        {
            Database db = Database.GetInstance();
            string qry = String.Format("DELETE FROM venda WHERE id = {0};", key);
            db.ExecuteNonQuery(qry);
        }


        public List<Venda> ListAll()
        {
            VendaMotorDAO vm = new VendaMotorDAO();
            VendaOpcionalDAO vo = new VendaOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM venda";
            DataSet ds = db.ExecuteQuery(qry);

            List<Venda> lv = new List<Venda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Venda v = new Venda();
                v.Id = int.Parse(dr["id"].ToString());
                v.Cliente.Id = int.Parse(dr["idCliente"].ToString());
                v.Vendedor.Id = int.Parse(dr["idVendedor"].ToString());
                v.Carro.Id = int.Parse(dr["idCarro"].ToString());
                v.DataVenda = dr["dataVenda"].ToString();
                v.Desconto = double.Parse(dr["Desconto"].ToString());
                v.NParcelas = int.Parse(dr["nParcelas"].ToString());
                v.Juros = double.Parse(dr["juros"].ToString());
                v.PrecoCarro = double.Parse(dr["precoCarro"].ToString());
                v.PrecoTotal = double.Parse(dr["precoTotal"].ToString());
                v.Entrada = double.Parse(dr["entrada"].ToString());
                v.Restante = double.Parse(dr["restante"].ToString());
                v.ValParcela = double.Parse(dr["valParcela"].ToString());
                v.PrecoAPAgar = double.Parse(dr["PrecoAPagar"].ToString());
                v.IdCliente = int.Parse(dr["idCliente"].ToString());
                v.IdVendedor = int.Parse(dr["idVendedor"].ToString());
                v.IdCarro = int.Parse(dr["idCarro"].ToString());
                v.Removido = int.Parse(dr["removido"].ToString());

                v.Cliente = cliente.Read(v.Cliente.Id);
                v.Carro = carro.Read(v.Carro.Id);
                v.Vendedor = vendedor.Read(v.Vendedor.Id);
                v.Carro.Motor = vm.Read(v.Id);
                v.Carro.Opcional = vo.Read(v.Id);

                lv.Add(v);
            }


            return lv;
        }



        public List<Venda> ListByVendedor(string nome)
        {
            VendaMotorDAO vm = new VendaMotorDAO();
            VendaOpcionalDAO vo = new VendaOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM venda v JOIN funcionario f ON v.idVendedor = f.Id WHERE f.nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Venda> lv = new List<Venda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Venda v = new Venda();
                v.Id = int.Parse(dr["id"].ToString());
                v.Cliente.Id = int.Parse(dr["idCliente"].ToString());
                v.Vendedor.Id = int.Parse(dr["idVendedor"].ToString());
                v.Carro.Id = int.Parse(dr["idCarro"].ToString());
                v.DataVenda = dr["dataVenda"].ToString();
                v.Desconto = double.Parse(dr["Desconto"].ToString());
                v.NParcelas = int.Parse(dr["nParcelas"].ToString());
                v.Juros = double.Parse(dr["juros"].ToString());
                v.PrecoCarro = double.Parse(dr["precoCarro"].ToString());
                v.PrecoTotal = double.Parse(dr["precoTotal"].ToString());
                v.Entrada = double.Parse(dr["entrada"].ToString());
                v.Restante = double.Parse(dr["restante"].ToString());
                v.ValParcela = double.Parse(dr["valParcela"].ToString());
                v.PrecoAPAgar = double.Parse(dr["PrecoAPagar"].ToString());
                v.IdCliente = int.Parse(dr["idCliente"].ToString());
                v.IdVendedor = int.Parse(dr["idVendedor"].ToString());
                v.IdCarro = int.Parse(dr["idCarro"].ToString());
                v.Removido = int.Parse(dr["removido"].ToString());

                v.Cliente = cliente.Read(v.Cliente.Id);
                v.Carro = carro.Read(v.Carro.Id);
                v.Vendedor = vendedor.Read(v.Vendedor.Id);
                v.Carro.Motor = vm.Read(v.Id);
                v.Carro.Opcional = vo.Read(v.Id);

                lv.Add(v);
            }

            return lv;
        }

        public List<Venda> ListByCliente(string nome)
        {
            VendaMotorDAO vm = new VendaMotorDAO();
            VendaOpcionalDAO vo = new VendaOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM venda v JOIN cliente c ON v.idCliente = c.Id WHERE c.nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Venda> lv = new List<Venda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Venda v = new Venda();
                v.Id = int.Parse(dr["id"].ToString());
                v.Cliente.Id = int.Parse(dr["idCliente"].ToString());
                v.Vendedor.Id = int.Parse(dr["idVendedor"].ToString());
                v.Carro.Id = int.Parse(dr["idCarro"].ToString());
                v.DataVenda = dr["dataVenda"].ToString();
                v.Desconto = double.Parse(dr["Desconto"].ToString());
                v.NParcelas = int.Parse(dr["nParcelas"].ToString());
                v.Juros = double.Parse(dr["juros"].ToString());
                v.PrecoCarro = double.Parse(dr["precoCarro"].ToString());
                v.PrecoTotal = double.Parse(dr["precoTotal"].ToString());
                v.Entrada = double.Parse(dr["entrada"].ToString());
                v.Restante = double.Parse(dr["restante"].ToString());
                v.ValParcela = double.Parse(dr["valParcela"].ToString());
                v.PrecoAPAgar = double.Parse(dr["PrecoAPagar"].ToString());
                v.IdCliente = int.Parse(dr["idCliente"].ToString());
                v.IdVendedor = int.Parse(dr["idVendedor"].ToString());
                v.IdCarro = int.Parse(dr["idCarro"].ToString());
                v.Removido = int.Parse(dr["removido"].ToString());

                v.Cliente = cliente.Read(v.Cliente.Id);
                v.Carro = carro.Read(v.Carro.Id);
                v.Vendedor = vendedor.Read(v.Vendedor.Id);
                v.Carro.Motor = vm.Read(v.Id);
                v.Carro.Opcional = vo.Read(v.Id);

                lv.Add(v);
            }

            return lv;
        }

        public List<Venda> ListByCarro(string nome)
        {
            VendaMotorDAO vm = new VendaMotorDAO();
            VendaOpcionalDAO vo = new VendaOpcionalDAO();
            Database db = Database.GetInstance();
            string qry = "SELECT * FROM venda v JOIN carro c ON v.idCarro = c.Id WHERE c.nome LIKE '%" + nome + "%'";
            DataSet ds = db.ExecuteQuery(qry);

            List<Venda> lv = new List<Venda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Venda v = new Venda();
                v.Id = int.Parse(dr["id"].ToString());
                v.Cliente.Id = int.Parse(dr["idCliente"].ToString());
                v.Vendedor.Id = int.Parse(dr["idVendedor"].ToString());
                v.Carro.Id = int.Parse(dr["idCarro"].ToString());
                v.DataVenda = dr["dataVenda"].ToString();
                v.Desconto = double.Parse(dr["Desconto"].ToString());
                v.NParcelas = int.Parse(dr["nParcelas"].ToString());
                v.Juros = double.Parse(dr["juros"].ToString());
                v.PrecoCarro = double.Parse(dr["precoCarro"].ToString());
                v.PrecoTotal = double.Parse(dr["precoTotal"].ToString());
                v.Entrada = double.Parse(dr["entrada"].ToString());
                v.Restante = double.Parse(dr["restante"].ToString());
                v.ValParcela = double.Parse(dr["valParcela"].ToString());
                v.PrecoAPAgar = double.Parse(dr["PrecoAPagar"].ToString());
                v.IdCliente = int.Parse(dr["idCliente"].ToString());
                v.IdVendedor = int.Parse(dr["idVendedor"].ToString());
                v.IdCarro = int.Parse(dr["idCarro"].ToString());
                v.Removido = int.Parse(dr["removido"].ToString());

                v.Cliente = cliente.Read(v.Cliente.Id);
                v.Carro = carro.Read(v.Carro.Id);
                v.Vendedor = vendedor.Read(v.Vendedor.Id);
                v.Carro.Motor = vm.Read(v.Id);
                v.Carro.Opcional = vo.Read(v.Id);

                lv.Add(v);
            }

            return lv;
        }
        


        public int KeyVenda
        {
            get
            {
                return keyVenda;
            }

            set
            {
                keyVenda = value;
            }
        }
    }
}
