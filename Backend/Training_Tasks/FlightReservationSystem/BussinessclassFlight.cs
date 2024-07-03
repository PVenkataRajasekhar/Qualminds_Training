using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class BussinessclassFlight : Flight
    {
        public string amenities { get; set; }
        public override bool BookTicket()
        {

            if (availableSeats == 0)
            {
                return false;
            }
            return true;
        }
        public BussinessclassFlight(string FlightNumber, string Destination, int AvailableSeats, float BaggageAllowance, string Amenities)
        {
            flightNumber = FlightNumber;
            destination = Destination;
            availableSeats = AvailableSeats;
            baggageAllowance = BaggageAllowance;
            amenities = Amenities;
        }
        public override string DisplayFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("flightNumber  = {0}{1}", flightNumber, Environment.NewLine);
            sb.AppendFormat("Destination = {0}{1}", destination, Environment.NewLine);
            sb.AppendFormat("AvailableSeats = {0}{1}", availableSeats, Environment.NewLine);
            sb.AppendFormat("BaggageAllowance  = {0}{1}", baggageAllowance, Environment.NewLine);
            sb.AppendFormat("Amenities  = {0}{1}", amenities, Environment.NewLine);
            return sb.ToString();
        }
        public  string CancelBooking()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The ticket booked For the Bussiness class flight {flightNumber} is Cancelled");
            return sb.ToString();
        }
    }
    public  class SpecialBusinessClassFlight : BussinessclassFlight
    {
        public SpecialBusinessClassFlight(string FlightNumber, string Destination, int AvailableSeats, float BaggageAllowance, string Amenities)
    : base(FlightNumber, Destination, AvailableSeats, BaggageAllowance, Amenities)
        {
            flightNumber = FlightNumber;
            destination = Destination;
            availableSeats = AvailableSeats;
            baggageAllowance = BaggageAllowance;
            amenities = Amenities;
        }
        public sealed override string DisplayFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("flightNumber  = {0}{1}", flightNumber, Environment.NewLine);
            sb.AppendFormat("Destination = {0}{1}", destination, Environment.NewLine);
            sb.AppendFormat("AvailableSeats = {0}{1}", availableSeats, Environment.NewLine);
            sb.AppendFormat("BaggageAllowance  = {0}{1}", baggageAllowance, Environment.NewLine);
            sb.AppendFormat("Amenities  = {0}{1}", amenities, Environment.NewLine);
            return sb.ToString();
        }
    }

}

