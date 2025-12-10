using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public class Database
    {
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public string PortNumber { get; set; }

        public Database(string serverAddress, string userName, string password, string databaseName, string portNumber)
        {
            ServerAddress = serverAddress;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            PortNumber = portNumber;
        }

        public MySqlConnection Connect()
        {
            string connStr =
                $"Server={ServerAddress};Port={PortNumber};User Id={UserName};Password={Password};Database={DatabaseName};";

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to database: " + ex.Message);
                return null;
            }
        }

        public int GetUserIdByUsername(string username)
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return -1;
                try
                {
                    conn.Open();
                    string sql = "SELECT idusers FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error fetching user ID: " + ex.Message);
                    return -1;
                }
            }
        }

        public bool CreateAdoptionRequest(int petId, int userId)
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return false;
                try
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM adoption_requests WHERE pet_id = @petId AND user_id = @userId AND status NOT IN ('Rejected', 'Cancelled', 'Completed')";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@petId", petId);
                    checkCmd.Parameters.AddWithValue("@userId", userId);

                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("You already have a pending or active request for this pet.", "Request Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    string insertSql = "INSERT INTO adoption_requests (pet_id, user_id, request_date, status) VALUES (@petId, @userId, NOW(), 'Pending')";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@petId", petId);
                    insertCmd.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting adoption request: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ExecuteQuery(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return null;
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message);
                    return null;
                }
            }
        }

        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return 0;
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing non-query: " + ex.Message);
                    return 0;
                }
            }
        }

        public (string role, bool success) LoginUser(string username, string password)
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return (null, false);
                try
                {
                    conn.Open();
                    string sql = "SELECT role FROM users WHERE username = @user AND password = @pass";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (result.ToString(), true);
                    }
                    return (null, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Error: " + ex.Message);
                    return (null, false);
                }
            }
        }

        public bool RegisterUser(string username, string password, string email, string role = "Adopter")
        {
            using (MySqlConnection conn = Connect())
            {
                if (conn == null) return false;
                try
                {
                    conn.Open();
                    string checkSql = "SELECT COUNT(*) FROM users WHERE username = @user";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@user", username);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Username already exists.", "Registration Failed");
                        return false;
                    }

                    string insertSql = "INSERT INTO users (username, password, email, role) VALUES (@user, @pass, @email, @role)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@user", username);
                    insertCmd.Parameters.AddWithValue("@pass", password);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@role", role);

                    return insertCmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}