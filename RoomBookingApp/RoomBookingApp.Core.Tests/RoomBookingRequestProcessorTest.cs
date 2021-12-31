using System;
using Xunit;
using Shouldly;

namespace RoomBookingApp.Core {

    public class RoomBookingRequestProcessorTest {

        [Fact]
        public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            // Arrange
            var bookingRequest = new RoomBookingRequest()
            {
                FullName = "Test name",
                Email = "test@example.com",
                Date = new DateTime(2021, 12, 30)
            };

            var processor = new RoomBookingRequestProcessor();

            // Act
            RoomBookingResult result = processor.BookRoom(bookingRequest);

            // Assert

            // Built in assert library
            Assert.NotNull(result);
            Assert.Equal(bookingRequest.FullName, result.FullName);
            Assert.Equal(bookingRequest.Email, result.Email);
            Assert.Equal(bookingRequest.Date, result.Date);
            Assert.NotEqual("test", result.FullName);
            Assert.NotEqual("test@test.com", result.Email);


            // Shoudly library
            result.ShouldNotBeNull();
            result.FullName.ShouldBe(bookingRequest.FullName);
            result.Email.ShouldBe(bookingRequest.Email);
            result.Date.ShouldBe(bookingRequest.Date);
            result.FullName.ShouldNotBe("test");
            result.Email.ShouldNotBe("test@test.com");

        }

        [Fact]
        public void Should_Through_Error_Message_For_Null_request() {

            // Arrange
            var processor = new RoomBookingRequestProcessor();

            // Act

            // Assertion library
            Should.Throw<ArgumentNullException>(() => processor.BookRoom(null));

        }
    }
}
