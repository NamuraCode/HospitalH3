using Hospital.domain.model;
using Hospital.domain.ports;
using Hospital.infraestructure.database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.infraestructure.adapters.output
{
    public class MySqlUserPort : UserPorts, IDisposable
    {
        private readonly DatabaseConnection dbConnection;
        private bool disposed = false;

        public void SaveUser(User user)
        {
            if (user == null)
                throw new ArgumentException("Socio no puede ser null");

            ValidateUser(user);

            using var connection = dbConnection.GetConnection();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Insert person
                using (var command = new MySqlCommand(
                    "INSERT INTO user (role, nameUser, password, name, email, phone, document) VALUES (@name, @cellPhone, @document); SELECT LAST_INSERT_ID();",
                    connection, transaction))
                {
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@nameUser", user.NameUser);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@document", user.Document);
                    command.Parameters.AddWithValue("@phone", user.Phone);
                    command.Parameters.AddWithValue("@dateBirth", user.DateBirth);
                    command.Parameters.AddWithValue("@direction", user.Direction);
                    user.Id = Convert.ToUInt64(command.ExecuteScalar());
                }
       
                // Insert emergency Contact
                using (var command = new MySqlCommand(
                    "INSERT INTO contact (name, email, document, phone, dateBirth, direction ) VALUES (@name, @email, @document, @phone, @dateBirth, @direction); SELECT LAST_INSERT_ID();",
                    connection, transaction))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@phone", user.Phone);
                    command.Parameters.AddWithValue("@document", user.Document);
                    command.Parameters.AddWithValue("@dateBirth", user.DateBirth);
                    command.Parameters.AddWithValue("@direction", user.Direction);
                    user.Id = Convert.ToUInt64(command.ExecuteScalar());
                }


                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        //private User CreateUserFromReader(MySqlDataReader reader)
        //{
        //    return new User
        //    {
        //        Id = reader.GetUInt64("id"),
        //        Name = reader.GetString("name"),
        //        Phone = (int)reader.GetInt64("phone"),
        //        Document = (ulong)reader.GetInt64("document"),
        //        NameUser = reader.GetString("user_name"),
        //        Password = reader.GetString("password"),
        //        Role = reader.GetString("role"),
        //        DateBirth = reader.GetDateTime("date_birth"),
        //        Direction = reader.GetString("direction"),
        //        Email = reader.GetString("email"),
        //        EmergencyContact = new Contact
        //        {
        //            Name = reader.GetString("contact_name"),
        //            Relation = reader.GetString("contact_relation"),
        //            PhoneNumber = reader.GetString("phoneNumber"),
        //        }

        //    };
        //}

        private void ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("El nombre es requerido");
            if (user.Document <= 0)
                throw new ArgumentException("El documento es inválido");
            if (user.Phone <= 0)
                throw new ArgumentException("El número de celular es inválido");
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("El nombre de usuario es requerido");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new ArgumentException("La contraseña es requerida");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbConnection.CloseConnection();
                }
                disposed = true;
            }
        }

        public bool FindUserById(ulong userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(ulong userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        ~MySqlUserPort()
        {
            Dispose(false);
        }
    }
}
