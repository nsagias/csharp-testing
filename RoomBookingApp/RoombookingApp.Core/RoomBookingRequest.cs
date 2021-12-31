using System;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequest
    {
        public RoomBookingRequest()
        {
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}