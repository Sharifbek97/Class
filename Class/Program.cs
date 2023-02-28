using Class;

/*var person = new Person();
person.FullName = "Ashurov A";
person.Adress = "sh.Dushanbe";
person.PhoneNumber = "+992 931 12 12 23";
person.BirthDay = DateTime.Parse("01.20.1992");*/

var person = new Person
{
    Name = "Ashur",
    LastName = "Ashurov",
    MiddleName = "Ashurovich",
    Adress = "sh.Dushanbe",
    PhoneNumber = "+992 931 12 12 23",
    BirthDay = DateTime.Parse("01.20.1992")
};
person.PrintFullName();
var age = person.GetAge(DateTime.Now.Year);
Console.WriteLine($"Adress: {person.Adress} \n PhoneNumber: {person.PhoneNumber} \n" +
                  $" BirthDay: {person.BirthDay.Date} \n Age: {age}");