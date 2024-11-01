using FluentAssertions;
using PriorityQueue_Example.Library;
namespace PriorityQueue_Example.Tests;

public class TestPriorityQueue
{
    [Fact]
    public void PeekShouldBePlatinumStatus()
    {
        PassengerBoarding boardingOrder = new();

        Passenger Jane = new Passenger("Jane", Status.Gold);
        Passenger Sally = new Passenger("Jack", Status.Bronze);
        Passenger Jill = new Passenger("Jill", Status.Platinum);
        Passenger Jack = new Passenger("Jack", Status.Silver);
        Passenger Phil = new Passenger("Phil", Status.Bronze);
        Passenger Sarah = new Passenger("Sarah", Status.Platinum);

        List<Passenger> ListOfPassengers = [Jane, Sally, Jill, Jack, Phil, Sarah];

        foreach (var Passenger in ListOfPassengers)
        {
            boardingOrder.Passengers.Enqueue(Passenger, Passenger.MedallionStatus);
        }

        boardingOrder.Passengers.Peek().Name.Should().Be("Jill");
    }
}
