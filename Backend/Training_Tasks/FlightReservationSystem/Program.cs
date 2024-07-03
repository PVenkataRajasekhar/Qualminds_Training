namespace FlightReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomesticFlight domesticFlight = new DomesticFlight("APJDSAI3","hyderabad",23,50,100);
            InternationalFlight internationalFlight = new InternationalFlight("FNNFFIJF", "USA", 32, 40, "yes");
            BussinessclassFlight bussinessclassFlight = new BussinessclassFlight("HFBEGF97", "UAE", 53, 60,"food is provided");
            SpecialBusinessClassFlight specialBusinessClassFlight=new SpecialBusinessClassFlight("ASNFFEAE", "Canada", 23, 50, "Double beds are provided");
            Console.WriteLine("domestic flight details :{0}",domesticFlight.DisplayFlightDetails());
            Console.WriteLine("ticket booked for domestic flight : {0}",domesticFlight.BookTicket());
            Console.WriteLine(domesticFlight.CheckBaggageAllowance());
            Console.WriteLine("International flight details :{0}", internationalFlight.DisplayFlightDetails());
            Console.WriteLine("ticket booked for international flight : {0}", internationalFlight.BookTicket());
            Console.WriteLine(internationalFlight.IsVisaRequired());
            Console.WriteLine("Bussiness class flight details :{0}", bussinessclassFlight.DisplayFlightDetails());
            Console.WriteLine("ticket booked for Bussiness class  flight : {0}", bussinessclassFlight.BookTicket());
            Console.WriteLine(bussinessclassFlight.CancelBooking());
            Console.WriteLine("Special Bussiness class flight details :{0}", specialBusinessClassFlight.DisplayFlightDetails());
        }
    }
}
