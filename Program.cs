using System;
namespace sevagir
{
    public class Building
    {
        public int Floors;      // harkeri qanak
        public int Area;        // taracq metrqarakusi
        public int Occupants;   // bnakichneri qanak
        public int area_for_onePerson;
    }

    public class BuildingDemo 

    {
       public static void Main()

        {
            try
            {
                Console.WriteLine("If you want input info abouth house then enter  word |house|," +
                    " and if abouth hotel enter |hotel|");

                string name = Convert.ToString(Console.ReadLine()!.ToLower());

                if (name == "house")
                {
                    Building house = new Building();

                    house.Occupants = Convert.ToInt32(Console.ReadLine());
                    house.Area = Convert.ToInt32(Console.ReadLine());
                    house.Floors = Convert.ToInt32(Console.ReadLine());
                    house.area_for_onePerson = house.Area / house.Occupants;

                    Console.WriteLine($"Shenqy uni {house.Area} qm." +
                        $" Uni {house.Floors} hark." +
                        $" Uni {house.Occupants} bnakaran" +
                        $" Marda {house.area_for_onePerson} m2");

                }
                else if (name == "hotel")
                {
                    Building hotel = new Building();
                    Console.WriteLine("Hark");
                    hotel.Floors = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Taracq");
                    hotel.Area = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hyurer");
                    hotel.Occupants = Convert.ToInt32(Console.ReadLine());
                    hotel.area_for_onePerson = hotel.Area / hotel.Occupants;

                    Console.WriteLine($"Uni {hotel.Floors} hark\n" +
                        $"Taracqy {hotel.Area} qm\n" +
                        $"Hyurer {hotel.Occupants}\n" +
                        $"Mi hyur hamar nax. taracq {hotel.area_for_onePerson}qm");


                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
       }
    }
}

