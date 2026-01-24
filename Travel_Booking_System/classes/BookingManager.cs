using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Booking_System.classes
{
    public class BookingManager
    {
		 private List<Booking> bookings=new List<Booking>();
        public BookingManager(Booking booking)
        {
        }
        public void addbooking(Booking booking)
		{
			if (booking.Trip.TripStatus == Tripstatus.available && booking.Seatscount <= booking.Trip.AvailableSeats)
			{
				bookings.Add(booking);
				Console.WriteLine("booking added successfully");
			}
				Console.WriteLine("booking failed");


		}
		public List<Booking> showallbookings()
		{
			if(bookings.Count > 0)
			{
				return bookings;
			}
			Console.WriteLine("there is no booking untill now");
			return null;
		}
		public Booking FindBookingByCustId(string custid)
		{ 
			for(int i=0;i<bookings.Count;i++)
			{
				Booking booking = bookings[i];
				if(booking.customer.id==custid)
				{
					return booking;
				}
				return null;

			}
			return null;
		}
		public List<Booking> findallbookingFilterTRips(string destination,DateTime date)
		{
			List<Booking> filteredBookings = new List<Booking>();
			for (int i = 0; i < bookings.Count;i++)
			{
				Booking booking = bookings[i];
				if (booking.Trip.Destination == destination|| booking.Trip.Date==date)
				{
					return filteredBookings;
				}
				return null;

			}
			return null;
		}

	}
}
