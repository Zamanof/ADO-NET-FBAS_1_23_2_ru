using Microsoft.SqlServer.Server;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_02._Configuration_file
{
    public partial class Form1 : Form
    {
        List<Author> authors = new List<Author>();
        string connectionString = ConfigurationManager
             .ConnectionStrings["DefaultConnectionString"]
             .ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDB(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new("SELECT * FROM Authors", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    authors.Add(new Author
                    {
                        Id = (int)reader[0],
                        FirstName = reader[1].ToString(),
                        LastName = reader[2].ToString(),
                    });
                }
                listBox1.DataSource = authors;
            }
        }
    }
}
