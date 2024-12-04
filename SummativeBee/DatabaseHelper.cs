using System;
using System.Data;
using System.Data.SQLite;

public class DatabaseHelper
{
    private string connectionString = "Data Source=budget.db;Version=3;";

    // Method to Insert Data
    public void InsertBudgetRecord(string type, decimal amount)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var query = "INSERT INTO BudgetRecords (Type, Amount) VALUES (@Type, @Amount);";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to Retrieve Data
    public DataTable GetBudgetRecords()
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT * FROM BudgetRecords ORDER BY DateAdded DESC;";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    // Method to Delete a Record
    public void DeleteRecord(int id)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var query = "DELETE FROM BudgetRecords WHERE ID = @ID;";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to Update a Record
    public void UpdateRecord(int id, string type, decimal amount)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var query = "UPDATE BudgetRecords SET Type = @Type, Amount = @Amount WHERE ID = @ID;";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
