using System;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        public RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
        {
            if (bookingRequest == null) {
                throw new ArgumentNullException(nameof(bookingRequest));
            }

            return new RoomBookingResult {
                //throw new NotImplementedException();
                FullName = bookingRequest.FullName,
                Email = bookingRequest.Email,
                Date = bookingRequest.Date,
            };
        }
    }
}