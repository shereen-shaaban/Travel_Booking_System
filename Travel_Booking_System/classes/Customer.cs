using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Booking_System.classes
{
    public class Customer
    {
        private string name;
        private string pass;
        private string customerid;
        private Gender gender;
        private int age;
		private 
		double points = 0;
        public string Name 
        { 
            get=>name;
			set
            {
                try
                {
                    if(!string.IsNullOrEmpty(value))
                        name=value;

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public string Pass 
        { 
            get=>pass;
			set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        pass = value;
                    }
                }catch( Exception ex)
                {
                    Console.WriteLine(ex.ToString()); 
                }
                }
        }
        public string Customerid 
        { 
            get=>customerid;
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value))
					{
						customerid = value;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
		}
        public Gender Gender 
        {
            get => gender;
			set
            {
                if(value==Gender.female)
                {
                    gender = Gender.female;
                }
                else if(value==Gender.male)
                {
					gender = Gender.male;
				}
                Console.WriteLine("invalid");
            }
        }
        public int Age 
        { 
            get=>age;
			set
            {
                if(value>=0)
                    age= value;
                Console.WriteLine("invalid");

            }
		}
        public double Points 
        {
            get => points;
            set => points = value;
        }


        public Customer()
        {

        }
        public void update(Customer cus)
        {

        }
        public void showdetails()
        {
            Console.WriteLine($"name:{Name},id:{Customerid},age:{Age},points:{Points},gender:{gender}");
        }

        public void redeempoints(double cost)
        {
            points= cost;

        }
    }
}
