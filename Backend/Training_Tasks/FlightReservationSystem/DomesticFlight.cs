using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class DomesticFlight : Flight
    {
        public int capacity { get; set; }
        public override bool BookTicket()
        {
            
            if (availableSeats == 0)
            {
                return false;
            }
            return true;
        }
        public DomesticFlight(string FlightNumber, string Destination, int AvailableSeats, float BaggageAllowance,int Capacity)
        {
            flightNumber = FlightNumber;
            destination = Destination;
            availableSeats = AvailableSeats;
            baggageAllowance = BaggageAllowance;
            capacity = Capacity;
        }
        public string CheckBaggageAllowance()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The Baggage Allowance For the Domestic flight {flightNumber} is {baggageAllowance} kg");
            return sb.ToString();
        }
        public override string DisplayFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("flightNumber  = {0}{1}", flightNumber, Environment.NewLine);
            sb.AppendFormat("Destination = {0}{1}", destination, Environment.NewLine);
            sb.AppendFormat("AvailableSeats = {0}{1}", availableSeats, Environment.NewLine);
            sb.AppendFormat("BaggageAllowance  = {0}{1}", baggageAllowance, Environment.NewLine);
            sb.AppendFormat("Capacity  = {0}{1}", capacity, Environment.NewLine);
            return sb.ToString();
        }
    }
}
