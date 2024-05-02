using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public abstract class Flight
    {
        public string flightNumber { get; set; }
        public string destination { get; set; }
        public int availableSeats { get; set; }
        public float baggageAllowance { get; set; }
        public abstract bool BookTicket();
        
        public virtual string DisplayFlightDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("flightNumber  = {0}{1}", flightNumber, Environment.NewLine);
            sb.AppendFormat("Destination = {0}{1}", destination, Environment.NewLine);
            sb.AppendFormat("AvailableSeats  = {0}{1}", availableSeats, Environment.NewLine);
            sb.AppendFormat("BaggageAllowance  = {0}{1}f", baggageAllowance, Environment.NewLine);
            return sb.ToString();
        }
        public string UpdateBaggageAllowance()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Updating the BaggageAllowance for all flights ");
            return sb.ToString();
        }
    }
}
