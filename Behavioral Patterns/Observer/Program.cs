namespace Observer;

class Program
{
    static void Main()
    {
        Person alex = new Person("Alex");
        Person jacob = new Person("Jacob");

        AirCompany airCompany = new AirCompany("Air-Top");
        airCompany.Register(alex);
        airCompany.Register(jacob);

        airCompany.DelayFlight(DateTime.Now.AddHours(2));
    }
}
