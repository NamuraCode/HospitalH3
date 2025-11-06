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
            connectionString = "Server=localhost;Port=3306;Database=hospital;User=root;Password=;";
            threadLocalConnection = new ThreadLocal<MySqlConnection>();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                    return instance;
                }
            }
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = threadLocalConnection.Value;

                if (connection == null)
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

        private void CreateDatabase()
        {
            string createDbConnectionString = "Server=localhost;Port=3306;Database=hospital;User=root;Password=;";
            using var connection = new MySqlConnection(createDbConnectionString);
            tempConnectio.Open();

            using var command = new MySqlCommand(GetCreateDatabaseScript(), tempConnectio);
            command.ExecuteNonQuery();
        }

        private string GetCreateDatabaseScript()
        {
            return @"
                DROP DATABASE IF EXISTS hospital;   
                CREATE DATABASE hospital;
                USE hospital;

                CREATE TABLE usuarios (
                    id BIGINT AUTO_INCREMENT PRIMARY KEY,
                    name_user VARCHAR(50) NOT NULL,
                    password VARCHAR(255) NOT NULL,
                    role VARCHAR(20) NOT NULL,
                    name VARCHAR(100) NOT NULL,
                    document BIGINT NOT NULL,
                    email VARCHAR(100) NOT NULL,
                    phone INT NOT NULL,
                    date_birth DATE NOT NULL,
                    direction VARCHAR(255) NOT NULL,
                );

                CREATE TABLE contactoDeEmergencia (
                    FOREIGN KEY (user_id) REFERENCES usuarios(id),
                    contact_name VARCHAR(100) NOT NULL,
                    contact_relation VARCHAR(50) NOT NULL,
                    contact_phone VARCHAR(20) NOT NULL,
                    contact_email VARCHAR(100) NOT NULL
                );

               
            ";
        }

    }
}
