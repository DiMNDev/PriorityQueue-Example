namespace PriorityQueue_Example.Library;

public class PassengerBoarding
{
    public PriorityQueue<Passenger, Status> Passengers { get; set; } = new();

}

public class Passenger
{
    public string Name { get; set; }
    public Status MedallionStatus { get; set; }

    public Passenger(string name, Status status)
    {
        Name = name;
        MedallionStatus = status;
    }
}

public enum Status
{
    Platinum,
    Gold,
    Silver,
    Bronze
}