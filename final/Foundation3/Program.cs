
class Program
{
    static void Main(string[] args)
    {
       
        Address address = new Address("555 Main St", "Harrisonburg", "VA", "22807");

       
        Lecture lecture = new Lecture("Intro to C#", "Learn the basics of C#", DateTime.Now, "1:00 PM", address, "John Doe", 100);
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

     
        Reception reception = new Reception("Company Mixer", "Meet and greet with company employees", DateTime.Now, "5:00 PM", address, "rsvp@company.com");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

      
        OutdoorGathering gathering = new OutdoorGathering("Company Picnic", "Enjoy food and games at the park", DateTime.Now, "12:00 PM", address, "Sunny with a chance of rain");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}
