using Class;

var person = new Person();

person.Name = "Sharifbek";
person.LastName = "Mirzozoda";
person.MiddleName = "Khursand";
person.BirthDay = Convert.ToDateTime("12-20-1973");

person.PrintFullNameAndAge(person.GetFullName(),person.GetAge());

Console.WriteLine($"ShortName: {person.GetShortName()} " +
                  $"BirthDay: {person.BirthDay}   Age: {person.GetAge()}");


var colculater = new Colculater();
Console.WriteLine("Number 1: ");
double A = double.Parse(Console.ReadLine()); 
Console.WriteLine("Number 2: ");
double B = double.Parse(Console.ReadLine()); 
        Console.WriteLine($"\n\tSumma: {colculater.Summa (A,B)} \n\tDifference: {colculater.Difference(A,B)}"+
                          $"\n\tMultiply: {colculater.Multiply(A,B)}  \n\tDivision: {colculater.Division(A,B)}");