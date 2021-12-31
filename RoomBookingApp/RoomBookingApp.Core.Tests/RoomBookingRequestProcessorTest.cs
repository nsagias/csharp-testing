﻿using System;
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
 

            // Shoudly library
            result.ShouldNotBeNull();
            

        }
    }
}
