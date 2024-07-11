using System.Data;
using System.Data.SqlClient;

namespace ADO_02._DataTable
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private DataTable table;
        private SqlDataReader reader;
        private string cs = @"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library";
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = queryTextBox.Text;
                ResultDataGridView.DataSource = null;
                conn.Open();
                table = new DataTable();
                reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }
                do
                {
                    while (reader.Read())
                    {
                        DataRow dr = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dr[i] = reader[i];
                        }
                        table.Rows.Add(dr);
                    }
                } while (reader.NextResult());
                ResultDataGridView.DataSource = table;

            }
        }
    }
}
