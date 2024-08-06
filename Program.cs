using System;
namespace POOemCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
        }
        public class Room
        {
            public Room(int seats)
            {
                Seats = seats;
                seatsInUse = 0;
            }

            private int seatsInUse = 0;
            public int Seats {get; set;}

            public void ReserveSeat()
            {
                seatsInUse++;
                if(seatsInUse >= Seats)
                {
                    //evento fechado
                    
                } else {
                    Console.WriteLine("Assento reservado");
                }
            }
        }
    }
}