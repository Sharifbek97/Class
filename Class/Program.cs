using Class;


//Project 1
/*var person = new Person();

person.Name = "Sharifbek";
person.LastName = "Mirzozoda";
person.MiddleName = "Khursand";
person.BirthDay = Convert.ToDateTime("12-20-1973");

person.PrintFullNameAndAge(person.GetFullName(),person.GetAge());

Console.WriteLine($"ShortName: {person.GetShortName()} " +
                  $"BirthDay: {person.BirthDay}   Age: {person.GetAge()}");*/

//Project 2
/*var colculater = new Colculater();
Console.WriteLine("Number 1: ");
double A = double.Parse(Console.ReadLine()); 
Console.WriteLine("Number 2: ");
double B = double.Parse(Console.ReadLine()); 
        Console.WriteLine($"\n\tSumma: {colculater.Summa (A,B)} \n\tDifference: {colculater.Difference(A,B)}"+
                          $"\n\tMultiply: {colculater.Multiply(A,B)}  \n\tDivision: {colculater.Division(A,B)}");*/
                          
                          
//Project 3
var cycle = new Cycle();

Console.Write("Radius of cycle: R = ");
double R = double.Parse(Console.ReadLine()); 
double PI=3.14;
Console.WriteLine($"\n\tArea of cycle: {cycle.Area(PI,R)}  \n\tPerimeter of cycle: {cycle.Perimeter(PI,R)}");

                          
                          