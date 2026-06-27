namespace TransportChallenge;

public class Helicopter : Vehicle, IDriveable, IFlyable
{
    public override string Move()
    {
        return "Flying in the sky.";
    }

    public void Drive()
    {
    }

    public void Fly()
    {
    }
}