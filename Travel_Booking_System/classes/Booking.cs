using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Booking_System.classes
{
    public class Booking
    {
        private string bookingid;
        private DateTime date;
        private int seatscount;
        private Bookingstatus bookingstatus;
        private double cost;

		Customer customer;
        Trip trip;
        public Booking()
        {
            bookingid = Guid.NewGuid().ToString();
        }
        public Booking(Trip trip, Customer customer, int Seats)
        {
            
            this.trip = trip;
            this.customer = customer;
            this.Seatscount = Seats;
            bookingid = Guid.NewGuid().ToString();

        }
        
		public string Bookingid { get => bookingid; }
        public DateTime Date 
        {
            get => date;
            set
            {
                if(value>DateTime.Now)
                    date = value;
                Console.WriteLine("invalid");

			}
        }

        public int Seatscount 
        { 
            get=> seatscount;
            set
            {
                if(value>=0)
                    seatscount = value;
                Console.WriteLine("invalid");
            }
        }

        public Bookingstatus BookingStatus 
        { 
            get=> bookingstatus;
            set
            {
                if(value==Bookingstatus.pending)
                    bookingstatus = value;
                else if(value==Bookingstatus.canceled )
                    bookingstatus = value;
                else if (value==Bookingstatus.confirmed)
                    bookingstatus = value;
                Console.WriteLine("invalid");
            }
        }
        public double Cost { get => calculate_cost(); }

        private double calculate_cost()
        {
            cost = trip.Price * Seatscount;
			return cost;
        }
		public void show()
		{
			Console.WriteLine($"Booking ID: {Bookingid}");
			Console.WriteLine($"Date: {Date}");
			Console.WriteLine($"Seats: {Seatscount}");
			Console.WriteLine($"Status: {BookingStatus}");
			Console.WriteLine($"Cost: {Cost}");
			Console.WriteLine($"Customer: {customer?.Name}"); 
			Console.WriteLine($"Trip: {trip?.Tripid}");
		}
		public void confirm    ()
        {
            if (bookingstatus == Bookingstatus.confirmed)
            {
				trip.Availbleseats -= seatscount;
                customer.Points += (int)trip.Price;
				Console.WriteLine("Booking confirmed successfully!");
			}

              


		}

    }
}
