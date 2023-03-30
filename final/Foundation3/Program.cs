using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Oak St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Elm St", "Somewhere", "TX", "54321");
        Event event1 = new Lecture("How to Code", "Learn coding from the experts", new DateTime(2023, 4, 1), "2:00 PM", address1, "John Doe", 50);
        Event event2 = new Reception("Networking Mixer", "Meet other professionals in your field", new DateTime(2023, 4, 15), "6:00 PM", address2, "rsvp@example.com");
        Event event3 = new OutdoorGathering("Picnic in the Park", "Join us for a fun day outside", new DateTime(2023, 5, 1), "11:00 AM", address3, "Weather forecast: Sunny and warm");

        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event2.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine(event3.GetShortDescription());
        Console.WriteLine();
        Console.ReadLine();
    }
}