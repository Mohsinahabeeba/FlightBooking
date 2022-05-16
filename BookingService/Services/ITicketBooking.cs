using BookingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Services
{
   public interface ITicketBooking
    {
        List<TblBookingDetails> GetBookingDetails(string emailId);
        void BookFlight(TblBookingDetails tblBookingDetail);
    }
}
