using BookingService.Models;
using BookingService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Controllers
{
    [Route("api/flight")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        ITicketBooking _ticketBooking;
        public BookingController(ITicketBooking ticketBooking)
        {
            _ticketBooking = ticketBooking;
        }
        [HttpGet("booking/history/{emailId}")]
        public IActionResult FlightBook(string emailId)
        {
            try
            {
                return Ok(_ticketBooking.GetBookingDetails(emailId));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("booking/flightdetails")]
        public IActionResult BookFlight(TblBookingDetails bookingDetail)
        {
            if (bookingDetail != null)
            {
                _ticketBooking.BookFlight(bookingDetail);
                return Ok();
            }
            return BadRequest();
        }
    }
}
