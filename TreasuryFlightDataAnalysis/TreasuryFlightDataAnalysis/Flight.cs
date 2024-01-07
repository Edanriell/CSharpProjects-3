using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasuryFlightDataAnalysis
{
    internal record Flight(
        string Agency,
        double PaidFare,
        string TripType,
        string RoutingType,
        string TicketClass,
        string DepartureDate,
        string Origin,
        string Destination,
        string DestinationCountry,
        string Carrier
    );
}
