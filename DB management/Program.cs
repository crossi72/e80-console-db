using System.Data;
using System.Data.SqlClient;

string connectionString = "Data Source=(local);" +
"Initial Catalog=prenotazioni;Integrated Security=True";
string queryString = "SELECT * FROM clienti WHERE id_cliente < 10";
SqlConnection connection;
SqlCommand command;
SqlDataReader reader;
SqlDataAdapter adapter;
DataTable dataTable;

//create a DB connection
using (connection = new SqlConnection(connectionString))
{
	command = new SqlCommand(queryString, connection);
	connection.Open();
	reader = command.ExecuteReader();

	while (reader.Read())
	{
		Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0), 
		reader.GetString(1), reader.GetString(2));
	}

	reader.Close();

	adapter = new SqlDataAdapter(queryString, connection);

	DataSet dataSet = new DataSet();
	adapter.Fill(dataSet, "Customers");

	command.ExecuteNonQuery();

	dataTable = dataSet.Tables["Customers"];

	foreach (DataRow row in dataTable.Rows)
	{
		Console.WriteLine(row["id_cliente"] + "\t" + row["nome"] + "\t" + row["cognome"]);
	}
}
