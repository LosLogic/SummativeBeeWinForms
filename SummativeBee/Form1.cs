using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;
using System.Web.UI.DataVisualization.Charting;

namespace SummativeBee
{
    public partial class Form1 : Form
    {
        private decimal totalIncome = 0;
        private decimal totalExpenses = 0;
        private string connectionString = "Data Source=budget.db;Version=3;";
        private DatabaseHelper dbHelper = new DatabaseHelper();


        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code or leave blank if not needed.
            MessageBox.Show("Form loaded successfully!");
        }


        private void InitializeChart()
        {
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Expenses vs Income");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Months";
            chart1.ChartAreas[0].AxisY.Title = "Amount";
        }

        private void UpdateChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY("Income", totalIncome);
            chart1.Series[0].Points.AddXY("Expenses", totalExpenses);
        }

        private void AddIncome(decimal amount)
        {
            totalIncome += amount;
            totalIncomeLabel.Text = $"Total Income: {totalIncome:C}";
            UpdateChart();
        }

        private void AddExpense(decimal amount)
        {
            totalExpenses += amount;
            totalExpensesLabel.Text = $"Total Expenses: {totalExpenses:C}";
            UpdateChart();
        }

        private void LoadDataIntoGrid()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var adapter = new SQLiteDataAdapter("SELECT * FROM BudgetRecords", conn);
                var dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }



        private void CreateDatabaseIfNotExists()
        {
            if (!System.IO.File.Exists("budget.db"))
            {
                SQLiteConnection.CreateFile("budget.db");
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    var createTableQuery = @"
                        CREATE TABLE BudgetRecords (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Type TEXT NOT NULL,
                            Amount DECIMAL NOT NULL,
                            DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP
                        );";
                    var cmd = new SQLiteCommand(createTableQuery, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void expensesButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter expense amount:", "Add Expense", "0");
            if (decimal.TryParse(input, out decimal expenseAmount))
            {
                AddExpense(expenseAmount);
            }
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter income amount:", "Add Income", "0");
            if (decimal.TryParse(input, out decimal incomeAmount))
            {
                AddIncome(incomeAmount);
            }
        }
    }
}

