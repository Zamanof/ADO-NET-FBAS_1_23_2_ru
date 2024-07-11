using System.Data;
using System.Data.SqlClient;

namespace ADO_03._DbDataAdapter
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommandBuilder cmd;
        private string cs = @"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library";
        public Form1()
        {
            InitializeComponent();
            conn = new();
            conn.ConnectionString = cs;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            dataSet = new();
            string query = queryTextBox.Text;
            adapter = new SqlDataAdapter(query, conn);
            resultDataGridView.DataSource = null;
            cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(dataSet, "authors");
            resultDataGridView.DataSource = dataSet.Tables["authors"];
            queryTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            adapter.Update(dataSet, "authors");
            //MessageBox.Show($"{cmd.GetUpdateCommand().CommandText}\n{cmd.GetInsertCommand().CommandText}\n{cmd.GetDeleteCommand().CommandText}");
        }
    }
}
