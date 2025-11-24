using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.infraestructure.database
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private readonly string connectionString;
        private static readonly object padlock = new();
        private readonly ThreadLocal<MySqlConnection> threadLocalConnection;

        private DatabaseConnection()
        {
            connectionString = "Server=localhost;Port=3306;Database=clinica;User=root;Password=;";
            threadLocalConnection = new ThreadLocal<MySqlConnection>();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padlock)
                    {
                        instance ??= new DatabaseConnection();
                    }
                }
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = threadLocalConnection.Value;

                if (connection == null || connection.State == System.Data.ConnectionState.Closed)
                {
                    connection = new MySqlConnection(connectionString);
                    threadLocalConnection.Value = connection;
                }

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (MySqlException ex) when (ex.Number == 1049){
                CreateDatabase();
                var connection = new MySqlConnection(connectionString);
                threadLocalConnection.Value = connection;
                connection.Open();
                return connection;
            }
        }

        public void CloseConnection()
        {
            var connection = threadLocalConnection.Value;
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();   
                threadLocalConnection.Value = null;
            }
        }

        private void CreateDatabase()
        {
            string createDbConnectionString = "Server=localhost;Port=3306;User=root;Password=;";
            using var connection = new MySqlConnection(createDbConnectionString);
            connection.Open();

            using var command = new MySqlCommand(GetCreateDatabaseScript(), connection);
            command.ExecuteNonQuery();
        }

        private string GetCreateDatabaseScript()
        {
            return @"
                DROP DATABASE IF EXISTS clinica;   
                CREATE DATABASE clinica;
                USE clinica;

                CREATE TABLE personas (
                    id BIGINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
                    name VARCHAR(100) NOT NULL,
                    document BIGINT NOT NULL,
                    email VARCHAR(100) NOT NULL,
                    phone VARCHAR(50) NOT NULL,
                    date_birth DATE NOT NULL,
                    direction VARCHAR(255) NOT NULL
                );

                CREATE TABLE usuarios (
                    id BIGINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
                    id_person BIGINT UNSIGNED NOT NULL,
                    name_user VARCHAR(50) NOT NULL,
                    password VARCHAR(255) NOT NULL,
                    role VARCHAR(20) NOT NULL,
                    FOREIGN KEY (id_person) REFERENCES personas(id) ON DELETE CASCADE
                );

                CREATE TABLE contact_de_emergencia (
                    id BIGINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
                    id_person BIGINT UNSIGNED NOT NULL,
                    name VARCHAR(100) NOT NULL,
                    relation VARCHAR(50) NOT NULL,
                    phone VARCHAR(20) NOT NULL,
                    FOREIGN KEY (id_person) REFERENCES personas(id) ON DELETE CASCADE
                );
            ";
        }

    }
}
