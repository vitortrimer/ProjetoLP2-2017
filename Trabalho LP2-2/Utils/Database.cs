﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Trabalho_LP2_2
{
    class Database
    {
        private static MySqlConnection connection;
        private static Database instance;
        private const string URL = "Server=localhost; Database=trabalholp2; Uid=root; Pwd=; ";
         
        private Database()
        {
            connection = new MySqlConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteNonQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            comm.ExecuteNonQuery();

            connection.Close();
        }

        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            connection.Close(); 
            return ds;
        }

    }
}
