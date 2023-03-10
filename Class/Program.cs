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
/*var calculator = new Calculator();
Console.WriteLine("Number 1: ");
double A = double.Parse(Console.ReadLine()); 
Console.WriteLine("Number 2: ");
double B = double.Parse(Console.ReadLine()); 
        Console.WriteLine($"\n\tSumma: {calculator.Addition (A,B)} \n\tDifference: {calculator.Subtraction(A,B)}"+
                          $"\n\tMultiply: {calculator.Multiply(A,B)}  \n\tDivision: {calculator.Division(A,B)}");*/
                          
                          
//Project 3
/*var cycle = new Cycle();

Console.Write("Radius of cycle: R = ");
double R = double.Parse(Console.ReadLine()); 
double PI=3.14;
Console.WriteLine($"\n\tArea of cycle: {cycle.Area(PI,R)}  \n\tPerimeter of cycle: {cycle.Perimeter(PI,R)}");*/
                          
//Project 4
/*var student = new Student();

student.Name = "Ahmad";
student.SurName = "Umarzoda";
student.MidleName = "Bobomurodovich";
student.BirthDay = Convert.ToDateTime("01-16-2003");
student.GetPrintStudent(student.GetAge(), student.GetFullName(),  student.GetShortName());


/*Console.WriteLine($"\n\tSurname: {student.SurName} \n\tName: {student.Name}"+
                  $"\n\tMidleName: {student.MidleName} \n\tBirthDay: {student.BirthDay}"+
                  $"\n\tAge: {student.GetAge()}");
Console.WriteLine($"\n\tFullName: {student.GetFullName()} \n\tShortName: {student.GetShortName()}");*/
                     
                     
//Project 5
/*var book = new Book();

book.Name = "Pry Algebra 2";
book.Author = "T. Gafur, K.Mustafo, K.Murat.";
book.YearOfPublication=2006;
book.Page = 263;
book.PrintBook(book.GetNameAuthor(),book.GetYearOfPublication(), book.GetPage());
Console.WriteLine("\n\nIs new the year of writing the book ");
bool year = true;
if ( book.YearOfPublication>= 2021)
{
   Console.WriteLine(year); 
}
else {Console.WriteLine(false);}*/

    //Project 6
/*var complexNumber = new ComplexNumber();
Console.WriteLine("Part of real: ");
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Part of imaginar: ");
int b = int.Parse(Console.ReadLine()); 

Console.WriteLine($"Constructed complex number: {complexNumber.GetReal(a)}i+{complexNumber.GetImaginary(b)}");*/

//Project 7
var triangle = new Triangle();

Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());
Console.Write("c= ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine($"Perimeter of triangle: {triangle.Perimeter(a,b,c)}  \nArea of triangle: {triangle.Area(a,b,c)}");

