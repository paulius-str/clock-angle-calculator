// See https://aka.ms/new-console-template for more information
using ClockAngleCounter.Extensions;

bool running = true;

while (running)
{
    Console.WriteLine("Enter hours");
    int hours = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter minutes");
    int minutes = int.Parse(Console.ReadLine());

    TimeOnly time = new TimeOnly(hours, minutes);

    float degreesBetweenArrows = time.DegreesBetweenArrows();
    Console.WriteLine($"Degrees Between Arrows: {degreesBetweenArrows}");
}
