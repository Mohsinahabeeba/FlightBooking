using BookingService.DbContexts;
using BookingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Services
{
    public class TicketBooking : ITicketBooking
    {
        BookingContext _ticketBooking;
        public TicketBooking(BookingContext ticketBooking)
        {
            _ticketBooking = ticketBooking;
        }
        public void BookFlight(TblBookingDetails tblBookingDetail)
        {
            _ticketBooking.TblBookingDetails.Add(tblBookingDetail);
            _ticketBooking.SaveChanges();
        }

        public List<TblBookingDetails> GetBookingDetails(string emailId)
        {
            return _ticketBooking.TblBookingDetails.Where(x => x.EmailId == emailId).ToList();
        }
    }
}
