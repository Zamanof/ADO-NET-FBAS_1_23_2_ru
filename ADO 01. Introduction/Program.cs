#region ADO
// ADO - ActiveX Data Object

// MS SQL SERVER, Oracle, ODBC, OLE DB

// class-i dlya raboti s bazami dannix
// DbConnection
// DbCommand
// DbDataReader
// DbDataAdapter

// tipi dannix dlya raboti s bazami dannix
// DataTabel
// DataSet
// ...

// Prisoyedenenniy rejim
// Otsoyedenenniy rejim
#endregion

#region ConnectionString
// Data Source=DESKTOP-PN0DMCN;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
// Data Source=DESKTOP-PN0DMCN; User Id=admin; Password=admin; Initial Catalog = TestAdo
// Server=DESKTOP-PN0DMCN;  User Id=admin; Password=admin; Database=TestAdo
// Server=DESKTOP-PN0DMCN; Database=TestAdo; Integrated Security=SSPI

#endregion

using System.Data.SqlClient;

string connectionString = @"Server=DESKTOP-PN0DMCN; Database=TestAdo; Integrated Security=SSPI";
SqlConnection sqlConnection = null;
sqlConnection = new SqlConnection(connectionString);

string insertString = @"INSERT INTO Authors(FirstName, LastName)
                           VALUES('Nadir', 'Zamanov')";
//SqlCommand command= new SqlCommand(insertString, sqlConnection);
SqlCommand command = new();
command.CommandText = insertString;
command.Connection = sqlConnection;

try
{
    sqlConnection.Open();
    command.ExecuteNonQuery();
}
finally
{
    if(sqlConnection != null) sqlConnection.Close();
}
