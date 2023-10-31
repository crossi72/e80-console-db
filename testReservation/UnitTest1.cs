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
			
			customers = reservation.Customers("Claudio", "Rossi");

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 5)
			{
				//test DB contains 5 Claudio Rossi
				throw new Exception("customers named Claudio Rossi count doesn't match");
			}		
			
			customers = reservation.Customers("doesn't", "Exists");

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 0)
			{
				//test DB contains 0 customer named "Doesn't Exists"
				throw new Exception("customers named Doesn't Exists count doesn't match");
			}
		}

		[TestMethod]
		public void TestReservations()
		{
			Reservation reservation = new Reservation();
			DataTable reservations;

			reservations = reservation.Reservations();

			if (reservations == null)
			{
				throw new Exception("reservations load failed");
			}
			if (reservations.Rows.Count != 9268)
			{
				//test DB contains 9268 reservations
				throw new Exception("reservations count doesn't match");
			}

			reservations = reservation.Reservations("Claudio", "Rossi");

			if (reservations == null)
			{
				throw new Exception("reservations load failed");
			}
			if (reservations.Rows.Count != 30)
			{
				//test DB contains 30 reservations for Claudio Rossi
				throw new Exception("reservations for Claudio Rossi count doesn't match");
			}

			reservations = reservation.Reservations("doesn't", "Exists");

			if (reservations == null)
			{
				throw new Exception("reservations load failed");
			}
			if (reservations.Rows.Count != 0)
			{
				//test DB contains 0 customer named "Doesn't Exists"
				throw new Exception("reservations for Doesn't Exists count doesn't match");
			}

			reservations = reservation.Reservations(5);

			if (reservations == null)
			{
				throw new Exception("reservations load failed");
			}
			if (reservations.Rows.Count != 1)
			{
				//test DB contains 1 reservation with ID 1
				throw new Exception("reservations for ID 1 count doesn't match");
			}

			reservations = reservation.Reservations(-1);

			if (reservations == null)
			{
				throw new Exception("reservations load failed");
			}
			if (reservations.Rows.Count != 0)
			{
				//test DB contains 0 reservation with ID 0
				throw new Exception("reservations for ID 0 count doesn't match");
			}
		}
	}
}