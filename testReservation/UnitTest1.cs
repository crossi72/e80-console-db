using classReservations;
using System.Data;

namespace testReservation
{
	[TestClass]
	public class UnitTestReservation
	{
		[TestMethod]
		public void TestCustomers()
		{
			Reservation reservation = new Reservation();
			DataTable customers;

			customers = reservation.Customers();

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 930)
			{
				//test DB contains 930 customers
				throw new Exception("customers count doesn't match");
			}
		}
	}
}