using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class InternationalFlight : Flight
    {
        public  string  visaRequirement { get; set; }
        public override bool BookTicket()
        {

            if (availableSeats == 0)
            {
                return false;
            }
            return true;
        }
        public InternationalFlight(string FlightNumber, string Destination, int AvailableSeats, float BaggageAllowance,string VisaRequirement)
        {
            flightNumber = FlightNumber;
            destination = Destination;
            availableSeats = AvailableSeats;
            baggageAllowance = BaggageAllowance;
            visaRequirement = VisaRequirement;
        }
        public override string DisplayFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("flightNumber  = {0}{1}", flightNumber, Environment.NewLine);
            sb.AppendFormat("Destination = {0}{1}", destination, Environment.NewLine);
            sb.AppendFormat("AvailableSeats = {0}{1}", availableSeats, Environment.NewLine);
            sb.AppendFormat("BaggageAllowance  = {0}{1}", baggageAllowance, Environment.NewLine);
            sb.AppendFormat("VisaRequirement = {0}{1}",visaRequirement, Environment.NewLine);
            return sb.ToString();
        }
        public string IsVisaRequired()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Visa For the International flight {flightNumber} is Required");
            return sb.ToString();
        }
    }
}
