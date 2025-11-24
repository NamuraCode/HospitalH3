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

        public MySqlUserPort()
        {
            dbConnection = DatabaseConnection.Instance;
        }

        public void SaveUser(User user)
        {
            if (user == null)
                throw new ArgumentException("Usuario no puede ser null");

            ValidateUser(user);

            using var connection = dbConnection.GetConnection();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Insert persona
                ulong idPersona;
                using (var command = new MySqlCommand(
                    @"INSERT INTO personas (name, email, document, phone, date_birth, direction) 
                     VALUES (@name, @email, @document, @phone, @date_birth, @direction);
                     SELECT LAST_INSERT_ID();",
                    connection, transaction))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@document", user.Document);
                    command.Parameters.AddWithValue("@phone", user.Phone);
                    command.Parameters.AddWithValue("@date_birth", user.DateBirth);
                    command.Parameters.AddWithValue("@direction", user.Direction);
                    idPersona = Convert.ToUInt64(command.ExecuteScalar());
                }

                // Insert usuarios
                using (var command = new MySqlCommand(
                     @"INSERT INTO usuarios (id_person, role, name_user, password) 
                      VALUES (@id_person, @role, @name_user, @password);
                      SELECT LAST_INSERT_ID();",
                     connection, transaction))
                {
                    command.Parameters.AddWithValue("@id_person", idPersona);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@name_user", user.NameUser);
                    command.Parameters.AddWithValue("@password", user.Password);
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
            if (string.IsNullOrWhiteSpace(user.Name)) throw new ArgumentException("Nombre requerido");
            if (user.Document <= 0) throw new ArgumentException("Documento inválido");
            if (string.IsNullOrWhiteSpace(user.Phone)) throw new ArgumentException("Teléfono inválido");
            if (string.IsNullOrWhiteSpace(user.NameUser)) throw new ArgumentException("Usuario requerido");
            if (string.IsNullOrWhiteSpace(user.Password)) throw new ArgumentException("Contraseña requerida");
            if (string.IsNullOrWhiteSpace(user.Role)) throw new ArgumentException("Rol requerido");
        }

        public bool FindUserById(ulong userId)
        {
            using var conn = dbConnection.GetConnection();
            using var cmd = new MySqlCommand("SELECT 1 FROM usuarios WHERE id = @id LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@id", userId);
            var result = cmd.ExecuteScalar();
            return result != null;
        }

        public void DeleteUser(ulong userId)
        {
            using var conn = dbConnection.GetConnection();
            using var cmd = new MySqlCommand("DELETE FROM usuarios WHERE id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            using var conn = dbConnection.GetConnection();
            using var cmd = new MySqlCommand(@"
                UPDATE usuarios SET name_user = @name_user, password = @password, role = @role
                WHERE id = @id;", conn);
            cmd.Parameters.AddWithValue("@name_user", user.NameUser);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.ExecuteNonQuery();
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

        ~MySqlUserPort() => Dispose(false);
    }
}
