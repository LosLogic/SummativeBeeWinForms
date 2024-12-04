using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SummativeBee
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.savingGoalsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.totalExpensesLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidebarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.sidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidebarPanel.Controls.Add(this.chart1);
            this.sidebarPanel.Controls.Add(this.dashboardButton);
            this.sidebarPanel.Controls.Add(this.incomeButton);
            this.sidebarPanel.Controls.Add(this.expensesButton);
            this.sidebarPanel.Controls.Add(this.savingGoalsButton);
            this.sidebarPanel.Controls.Add(this.reportsButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 450);
            this.sidebarPanel.TabIndex = 0;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.Silver;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dashboardButton.Location = new System.Drawing.Point(0, 92);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(196, 23);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // incomeButton
            // 
            this.incomeButton.BackColor = System.Drawing.Color.Silver;
            this.incomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.incomeButton.Location = new System.Drawing.Point(0, 69);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(196, 23);
            this.incomeButton.TabIndex = 1;
            this.incomeButton.Text = "Income";
            this.incomeButton.UseVisualStyleBackColor = false;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // expensesButton
            // 
            this.expensesButton.BackColor = System.Drawing.Color.Silver;
            this.expensesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.expensesButton.Location = new System.Drawing.Point(0, 46);
            this.expensesButton.Name = "expensesButton";
            this.expensesButton.Size = new System.Drawing.Size(196, 23);
            this.expensesButton.TabIndex = 2;
            this.expensesButton.Text = "Expenses";
            this.expensesButton.UseVisualStyleBackColor = false;
            this.expensesButton.Click += new System.EventHandler(this.expensesButton_Click);
            // 
            // savingGoalsButton
            // 
            this.savingGoalsButton.BackColor = System.Drawing.Color.Silver;
            this.savingGoalsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.savingGoalsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savingGoalsButton.Location = new System.Drawing.Point(0, 23);
            this.savingGoalsButton.Name = "savingGoalsButton";
            this.savingGoalsButton.Size = new System.Drawing.Size(196, 23);
            this.savingGoalsButton.TabIndex = 3;
            this.savingGoalsButton.Text = "Saving Goals";
            this.savingGoalsButton.UseVisualStyleBackColor = false;
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.Silver;
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reportsButton.Location = new System.Drawing.Point(0, 0);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(196, 23);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.totalIncomeLabel);
            this.mainPanel.Controls.Add(this.totalExpensesLabel);
            this.mainPanel.Controls.Add(this.savingsLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(0, 169);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(196, 277);
            this.chart1.TabIndex = 0;
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.Location = new System.Drawing.Point(220, 20);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(100, 23);
            this.totalIncomeLabel.TabIndex = 1;
            this.totalIncomeLabel.Text = "Total Income:";
            // 
            // totalExpensesLabel
            // 
            this.totalExpensesLabel.Location = new System.Drawing.Point(220, 60);
            this.totalExpensesLabel.Name = "totalExpensesLabel";
            this.totalExpensesLabel.Size = new System.Drawing.Size(100, 23);
            this.totalExpensesLabel.TabIndex = 2;
            this.totalExpensesLabel.Text = "Total Expenses:";
            // 
            // savingsLabel
            // 
            this.savingsLabel.Location = new System.Drawing.Point(220, 100);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(100, 23);
            this.savingsLabel.TabIndex = 3;
            this.savingsLabel.Text = "Savings:";
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(220, 140);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(75, 23);
            this.addIncomeButton.TabIndex = 0;
            this.addIncomeButton.Text = "Add Income";
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(320, 140);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.addExpenseButton.TabIndex = 0;
            this.addExpenseButton.Text = "Add Expense";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(535, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 450);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Personal Budget Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Panel sidebarPanel;
        private Button dashboardButton;
        private Button incomeButton;
        private Button expensesButton;
        private Button savingGoalsButton;
        private Button reportsButton;
        private Panel mainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label totalIncomeLabel;
        private Label totalExpensesLabel;
        private Label savingsLabel;
        private Button addIncomeButton;
        private Button addExpenseButton;
        private DataGridView dataGridView1;
    }
}

