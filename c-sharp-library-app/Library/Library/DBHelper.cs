using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Library 
{
    public static class DBHelper
    {
        private static readonly string connectionString =
            "Data Source=localhost;port=3306;username=root;password=Drivingsupportworker@2520;database=library_manager;";

        public static MySqlConnection GetConnection() => new MySqlConnection(connectionString);

        public static DataTable GetAllBooks()
        {
            var dt = new DataTable();
            using var conn = GetConnection();
            using var cmd = new MySqlCommand("SELECT ID, Title, Author, Year, ISBN, Category FROM books ORDER BY Title", conn);
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }

        public static DataTable SearchBooks(string searchTerm)
        {
            var dt = new DataTable();
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(@"
                SELECT ID, Title, Author, Year, ISBN, Category
                FROM books
                WHERE Title LIKE @s OR Author LIKE @s OR ISBN LIKE @s OR Category LIKE @s
                ORDER BY Title", conn);
            cmd.Parameters.AddWithValue("@s", "%" + searchTerm + "%");
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }

        public static int AddBook(string title, string author, int? year, string isbn, string category)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(@"
                INSERT INTO books (Title, Author, Year, ISBN, Category)
                VALUES (@title, @author, @year, @isbn, @category);", conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", string.IsNullOrEmpty(author) ? "" : author);
            cmd.Parameters.AddWithValue("@year", (object)year ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@isbn", string.IsNullOrEmpty(isbn) ? "" : isbn);
            cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(category) ? "" : category);
            cmd.ExecuteNonQuery();

            using var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);
            var idObj = idCmd.ExecuteScalar();
            return Convert.ToInt32(idObj);
        }

        public static void UpdateBook(int id, string title, string author, int? year, string isbn, string category)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(@"
                UPDATE books
                SET Title=@title, Author=@author, Year=@year, ISBN=@isbn, Category=@category
                WHERE ID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", string.IsNullOrEmpty(author) ? "" : author);
            cmd.Parameters.AddWithValue("@year", (object)year ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@isbn", string.IsNullOrEmpty(isbn) ? "" : isbn);
            cmd.Parameters.AddWithValue("@category", string.IsNullOrEmpty(category) ? "" : category);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteBook(int id)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand("DELETE FROM books WHERE ID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static DataRow GetBookById(int id)
        {
            var dt = new DataTable();
            using var conn = GetConnection();
            using var cmd = new MySqlCommand("SELECT ID, Title, Author, Year, ISBN, Category FROM books WHERE ID=@id LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
