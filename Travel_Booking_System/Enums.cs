using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Booking_System
{
    public enum Gender
    {
        female,
        male
    }
	public enum Tripstatus
	{
		available,
		completed,
		canceled,
		deleted
	}
	public enum Destination
	{
		City_A,
		City_B,
		City_C,
	}
	public enum Bookingstatus
	{
		pending,
		canceled,
		confirmed
	}
}
