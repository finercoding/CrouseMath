using System.Collections.Generic;

namespace CrouseMath.Application.Bookings.Queries.GetBookingList
{
    public class BookingListViewModel
    {
        public IEnumerable<BookingLookupDto> Bookings { get; set; }
    }
}