using System.Data;
using System.Data.SqlClient;

namespace classReservations
{
	public class Reservation
	{

		string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;

		/// <summary>
		/// Default constructor, uses localhost and integrated authentication
		/// </summary>
		public Reservation()
		{
			this.connectionString = "Data Source=(local);Initial Catalog=prenotazioni;Integrated Security=True";
			this.ConnectToDB();
		}

		/// <summary>
		/// Default constructor, uses localhost and integrated authentication
		/// </summary>
		/// <param name="server">server name or address</param>
		/// <param name="database">database name</param>
		public Reservation(string server, string database)
		{
			this.connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True";
			this.ConnectToDB();
		}

		/// <summary>
		/// Default constructor, uses localhost and integrated authentication
		/// </summary>
		/// <param name="server">server name or address</param>
		/// <param name="database">database name</param>
		/// <param name="username">username</param>
		/// <param name="password">password</param>
		public Reservation(string server, string database, string username, string password)
		{
			this.connectionString = $"user id={username};data source='{server}';persist security info=True;initial catalog={database};password={password};MultipleActiveResultSets=true";
			this.ConnectToDB();
		}

		private void ConnectToDB()
		{
			this.connection = new SqlConnection(this.connectionString);

			this.connection.Open();
		}

		/// <summary>
		/// Loads all customers data
		/// </summary>
		/// <returns></returns>
		public DataTable Customers()
		{
			return this.Customers("", "");
		}

		/// <summary>
		/// Loads all customers data
		/// </summary>
		/// <returns></returns>
		public DataTable Customers(string firstName, string secondName)
		{
			string queryString;
			DataTable result;
			SqlCommand command;
			DataSet dataSet;

			//loads data from database
			queryString = "SELECT * FROM clienti";

			if ((firstName != "") && (secondName != ""))
			{
				queryString += $"\nWHERE cognome = '{secondName.Replace("'", "''")}' AND nome = '{firstName.Replace("'", "''")}'";
			}

			command = new SqlCommand(queryString, this.connection);
			//connection.Open();

			adapter = new SqlDataAdapter(queryString, this.connection);

			dataSet = new DataSet();
			adapter.Fill(dataSet, "Clienti");

			result = dataSet.Tables["Clienti"];

			return result;
		}

		/// <summary>
		/// Returns all reservations
		/// </summary>
		/// <returns>DataTable containing all reservations</returns>
		public DataTable Reservations()
		{
			return this.Reservations(0, "", "");
		}

		/// <summary>
		/// Returns a reservation
		/// </summary>
		/// <param name="reservation_id">ID of the reservation to load</param>
		/// <returns>DataTable containing the reservation</returns>
		public DataTable Reservations(int reservation_id)
		{
			return this.Reservations(reservation_id, "", "");
		}

		/// <summary>
		/// Returns all reservations for a customer
		/// </summary>
		/// <param name="customerFirstName">First name of the customer</param>
		/// <param name="customerSecondName">Second name of the customer</param>
		/// <returns></returns>
		public DataTable Reservations(string customerFirstName, string customerSecondName)
		{
			return this.Reservations(0, customerFirstName, customerSecondName);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="reservation_id">ID of the reservation to load</param>
		/// <param name="customerFirstName">First name of the customer</param>
		/// <param name="customerSecondName">Second name of the customer</param>
		/// <returns></returns>
		private DataTable Reservations(int reservation_id, string customerFirstName, string customerSecondName)
		{
			DataTable result;
			string queryString;
			SqlCommand command;
			DataSet dataSet;

			//loads data from database
			queryString = "SELECT prenotazioni.* FROM prenotazioni";

			if (reservation_id != 0) {
				//reservation id is not zero: find the reservation using the ID
				queryString += $"\nWHERE id_prenotazione = {reservation_id}";
			}

			if ((customerFirstName != "") && (customerSecondName != ""))
			{
				queryString += "\nINNER JOIN clienti ON id_cliente = cliente";
				queryString += $"\nWHERE cognome = '{customerSecondName.Replace("'", "''")}' AND nome = '{customerFirstName.Replace("'", "''")}'";
			}

			command = new SqlCommand(queryString, this.connection);
			//connection.Open();

			adapter = new SqlDataAdapter(queryString, this.connection);

			dataSet = new DataSet();
			adapter.Fill(dataSet, "Clienti");

			result = dataSet.Tables["Clienti"];
			return result;
		}
	}
}