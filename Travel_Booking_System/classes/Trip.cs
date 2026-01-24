using System;
using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Net.NetworkInformation;
//using System.Runtime.CompilerServices;
using System.Text;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Travel_Booking_System.classes
{
    public class Trip
    {
		private string tripid;
		private Destination _destination;
		private DateTime _date;
		private double _price;
		private int _availbleseats;
		private Tripstatus _tripstatus;
        public Trip()
        {
			tripid = Guid.NewGuid().ToString();

		}

        public Destination Destination 
        { 
            get=>_destination;
			set
            {
                if(value==Destination.City_B)
                    _destination = Destination.City_B;
                else if(value==Destination.City_C)
                    _destination = Destination.City_C;
                else if(value==Destination.City_A)
                    _destination = Destination.City_A;
                Console.WriteLine("invalid");
            }
        }
		
		public DateTime Date 
        { 
            get=>_date;
			set
            {
				if (value > DateTime.Now)
					_date = value;
			}
        }
		public double Price
		{
			get=>_price;
			set
			{
				if (Price >= 0)
					_price = value;
				Console.WriteLine("invalid");
			}
		}

		public int Availbleseats
		{
			get=>_availbleseats;
			set
			{
				if (value >= 0)
					_availbleseats = value;
				Console.WriteLine("invalid");
			}
		}


		public Tripstatus Tripstatus
		{
			get;
			set
			{
				if (value == Tripstatus.available)
					_tripstatus = Tripstatus.available;
				else if (value == Tripstatus.canceled)
					_tripstatus = Tripstatus.canceled;
				else if (value == Tripstatus.deleted)
					_tripstatus = Tripstatus.deleted;
				Console.WriteLine("invalid");
			}
		}

		public string Tripid
		{
			get => tripid;
			//private set;
		}
		public void UpdateMyTrip(Destination? newDestination = null, DateTime? newDate = null,
			  double? newprice = null, int? newAvailbleseats = null, Tripstatus? tripstatus = null)
		{
			if (newDestination.HasValue)
				this.Destination = newDestination.Value;
			if (newDate.HasValue)
				this.Date = newDate.Value;
			if (newprice.HasValue)
				this.Price = newprice.Value;
			if (newAvailbleseats.HasValue)
				this.Availbleseats = newAvailbleseats.Value;
			if (tripstatus.HasValue)
				this.Tripstatus = tripstatus.Value;
		}
		public void ShowMyTrip()
		{
			Console.WriteLine($"trip id:{Tripid},trip status:{Tripstatus},available seats:{Availbleseats},trip date:{Date}");

		}
		public void deletetrip(TripManager tripmanager)
		{
			tripmanager.deletetrip(this.Tripid);
		}
		


		


	}
}
