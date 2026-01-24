using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Travel_Booking_System.classes
{
    public class Tripmanager
	{
		//Trip manager

		private List<Trip> triplist = new List<Trip>();
		public void addtrip()
		{
			triplist.Add(new Trip());
		}
		public void addtrip(Trip trip)
		{
			triplist.Add(trip);
		}
		public void deletetrip(string id)
		{
			bool isfound = false;
			for (int i = 0; i < triplist.Count; i++)
			{
				Trip trip = triplist[i];
				if (trip.Tripid == id)
				{
					triplist.RemoveAt(i);
					Console.WriteLine("delete succesfuly");
					isfound = true;
					break;
				}
			}


			if (!isfound)
			{
				Console.WriteLine("there is no trip with that id");
			}
		}

		public void updatetrip(string id)
		{
			bool isfound = false;
			for (int i = 0; i < triplist.Count; i++)
			{
				Trip trip = triplist[i];
				if (trip.Tripid == id)
				{
					Console.WriteLine($"the trip hasdestination:{Trip.Destination},date:{Trip.Date},price:{Trip.Price},availbleseats:{Availbleseats},status:{Tripstatus}");
					Console.WriteLine("Enter updates in format Date=2023-12-25,Price=1500");
					string updatesInput = Console.ReadLine();
					if (string.IsNullOrEmpty(updatesInput))
					{
						Console.WriteLine("No updates provided.");
						return;
					}
					string[] updates = updatesInput.Split(',');
					foreach (string update in updates)
					{
						string[] parts = update.Split('=');
						if (parts.Length != 2)
						{
							Console.WriteLine($"Invalid update format: {update}");
							continue;
						}
						string field = parts[0].Trim().ToLower();
						string value = parts[1].Trim();
						switch (field.ToLower())
						{
							case "date":
								if (DateTime.TryParse(value, out DateTime newDate))
								{
									trip.Date = newDate;
								}
								else
								{
									Console.WriteLine($"Invalid date value: {value}");
								}
								break;
							case "price":
								if (double.TryParse(value, out double newPrice))
								{
									trip.Price = newPrice;
								}
								else
								{
									Console.WriteLine($"Invalid price value: {value}");
								}
								break;
							case "availbleseats":
								if (int.TryParse(value, out int newSeats))
								{
									trip.Availbleseats = newSeats;
								}
								else
								{
									Console.WriteLine($"Invalid availbleseats value: {value}");
								}
								break;
							case "tripstatus":
								if (Enum.TryParse(value, out Tripstatus tripstatus))
								{
									trip.Tripstatus = tripstatus;
								}
								else
								{
									Console.WriteLine($"Invalid tripstatus value: {value}");
								}
								break;
							default:
								Console.WriteLine($"Unknown field: {field}");
								break;
						}
					}
					Console.WriteLine("Trip updated successfully!");
					isfound = true;
					break;

				}
				if (!isfound)
				{
					Console.WriteLine("there no Trip with that id");
				}
			}
		}
		public List<Trip> showalltrip()
		{
			return triplist;
		}
		public void showtrip(string id)
		{
			bool isfound = false;
			for (int i = 0; i < triplist.Count; i++)
			{
				Trip t = triplist[i];
				if (t.Tripid == id)
				{
					Console.WriteLine($"Tripid:{Trip.Tripid}");
					isfound = true;
					break;
				}

			}
			if (!isfound)
				Console.WriteLine("there is no TRip with that id");

		}
	}
}
