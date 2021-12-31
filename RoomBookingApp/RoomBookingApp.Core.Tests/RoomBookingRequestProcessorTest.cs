using System;
using Xunit;
namespace RoomBookingApp.Core {

    public class RoomBookingRequestProcessorTest {

        [Fact]
        public void Should_Return_Room_Booking_Request() {

            var bookingRequest = new RoomBookingReques() {
                FullName = "Test name",
                Email = "test@example.com",
                Date = new DateTime(2021, 12, 30);
            }

            var processor = new RoomBookingRequestProcessor();
        }
    }
}
