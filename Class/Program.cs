﻿using Class;


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
var student = new Student();

student.Name = "Ahmad";
student.SurName = "Umarzoda";
student.MidleName = "Bobomurodovich";
student.BirthDay = Convert.ToDateTime("01-16-2003");
student.GetPrintStudent(student.GetAge(), student.GetFullName(),  student.GetShortName());


/*Console.WriteLine($"\n\tSurname: {student.SurName} \n\tName: {student.Name}"+
                  $"\n\tMidleName: {student.MidleName} \n\tBirthDay: {student.BirthDay}"+
                  $"\n\tAge: {student.GetAge()}");
Console.WriteLine($"\n\tFullName: {student.GetFullName()} \n\tShortName: {student.GetShortName()}");*/
                     
                     
                     
                     