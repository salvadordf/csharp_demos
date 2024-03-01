using Microsoft.Data.Sqlite;

namespace SQLiteTest1
{
    public partial class MainForm : Form
    {
        SqliteConnection? sqlite_conn = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private bool ConnectionOpen {  get => (sqlite_conn != null) && (sqlite_conn.State == System.Data.ConnectionState.Open); }
        private bool ConnectionClosed { get => (sqlite_conn != null) && (sqlite_conn.State == System.Data.ConnectionState.Closed); }

        private void AppendLog(string logMessage)
        {
            LogBox.Text += logMessage + Environment.NewLine;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlite_conn == null)
                {
                    string connectionString = "Data Source = database3.db";
                    sqlite_conn = new SqliteConnection(connectionString);
                    AppendLog("Connection created successfully.");
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error creating the connection: " + ex.Message);
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionClosed)
                {
                    sqlite_conn.Open();
                    AppendLog("Connection opened successfully.");
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error opening the connection: " + ex.Message);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionOpen)
                {
                    using (SqliteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        string sqlCommand =
                            @"INSERT INTO SampleTable (name, age) 
                                VALUES($name, $age);";
                        sqlite_cmd.CommandText = sqlCommand;
                        sqlite_cmd.Parameters.AddWithValue("$name", "usuario2");
                        sqlite_cmd.Parameters.AddWithValue("$age", 25);
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    AppendLog("Data inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error inserting data: " + ex.Message);
            }
        }

        private void CreateTableBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionOpen)
                {
                    using (SqliteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        string sqlCommand = "CREATE TABLE SampleTable (name TEXT, age INTEGER);";
                        sqlite_cmd.CommandText = sqlCommand;
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    AppendLog("Table created successfully.");
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error creating the table: " + ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionOpen)
                {
                    sqlite_conn.Close();
                    AppendLog("Connection closed successfully.");
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error closing the connection: " + ex.Message);
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionOpen)
                {
                    using (SqliteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        string sqlCommand = "SELECT * FROM SampleTable";
                        sqlite_cmd.CommandText = sqlCommand;
                        SqliteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                        while (sqlite_datareader.Read())
                        {
                            string name = sqlite_datareader.GetString(0);
                            int age = sqlite_datareader.GetInt32(1);
                            AppendLog($"Name: {name} Age: {age}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog("Error reading the data: " + ex.Message);
            }
        }
    }
}
