﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Threading;

namespace QuanLyQuanCafe.DAL_QLQC
{
    public class HandleDB
    {
        private static readonly Lazy<HandleDB> instance = new Lazy<HandleDB>(() => new HandleDB());
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True";

        private static HandleDB _instance;
        public static HandleDB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HandleDB();
                return _instance;
            }
        }


        private HandleDB() { }
        public void UpdateConnection()
        {
            string connectionStrType = String.Format(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True", Environment.MachineName);

            SqlConnection con = new SqlConnection(connectionStrType);
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                connectionStrType = String.Format(@"Data Source={0}\SQLEXPRESS;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True", Environment.MachineName);
                Console.WriteLine(String.Format("Exception: {0}\nNew connection string: {1}", e.Message, connectionStrType));
            }
            con.Close();

            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["ConnectionString"].Value = connectionStrType;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            connectionSTR = ConfigurationManager.AppSettings["ConnectionString"];
        }


        public DataTable ExecuteQuery(string query, Dictionary<String, String> parameters)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public DataTable ExecuteQueryProcedure(string procedure, Dictionary<String, String> parameters)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<String, String> parameters)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                data = command.ExecuteNonQuery();

                return data;
            }
        }

        public int ExecuteNonQueryProcedure(string procedure, Dictionary<String, String> parameters)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                data = command.ExecuteNonQuery();

                return data;
            }
        }

        public object ExecuteScalar(string query, Dictionary<String, String> parameters)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                data = command.ExecuteScalar();

                return data;
            }

        }
        public object ExecuteScalarProcedure(string procedure, Dictionary<String, String> parameters)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (String key in parameters.Keys)
                    {
                        command.Parameters.AddWithValue(key, parameters[key]);
                    }
                }
                data = command.ExecuteScalar();

                return data;
            }

        }
    }
}
