using System.Data;
using System.Data.SqlClient;

namespace classReservations
{
	public class Reservation
	{

		string connectionString;

		/// <summary>
		/// Default constructor, uses localhost and integrated authentication
		/// </summary>
		public Reservation()
		{
			this.connectionString = "Data Source=(local);Initial Catalog=prenotazioni;Integrated Security=True";
		}

		/// <summary>
		/// Default constructor, uses localhost and integrated authentication
		/// </summary>
		/// <param name="server">server name or address</param>
		/// <param name="database">database name</param>
		public Reservation(string server, string database)
		{
			this.connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True";
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
		}

		/// <summary>
		/// Loads all customers data
		/// </summary>
		/// <returns></returns>
		public DataTable Customers()
		{
			DataTable result;

			result= new DataTable();

			//loads data from database
			return result;
		}

	}
}