using ConsoleApp6;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

{
    List<Linq> linq = new List<Linq>();
    linq.Add(new Linq("Amir", 90, 200));
    linq.Add(new Linq("AHMAD", 80, 400));
    linq.Add(new Linq("REZA", 95, 400));
    linq.Add(new Linq("MOEIN", 100, 2000));

    var result = linq.OrderByDescending( x => x.AVG ).ToList();
    var re = linq.Where( x => x.AVG > 94 ).ToList();
    var doo = linq.Select( x => x.Name ).ToList();
    var didi = linq.Sum( x => x.AVG ).ToString();

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    
    Console.WriteLine("these are soretd by biggest avg");

    foreach (var item in result)
    {
        Console.WriteLine($"{"  "+ item.Name + " " + item.AVG + " " + item.DN}");
        Console.WriteLine("*******************");
    }
    Console.WriteLine("these are sorted by biggest avg since 94");

    foreach (var item in re)
    {
        Console.WriteLine($"{"  " + item.Name + " " + item.AVG + " " + item.DN}");
        Console.WriteLine("*******************");
    }
    Console.WriteLine("these are sorted by just name ");

    foreach (var item in doo)
    {
        Console.WriteLine(item);
        Console.WriteLine("*******************");
    }
    Console.WriteLine("sum of the avg");
    Console.WriteLine(didi);
    Console.WriteLine("**************************");

}