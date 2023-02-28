namespace Class;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime BirthDay { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }

    public int GetAge(int yearNow)
    {
        /*var age = DateTime.Now.Year - BirthDay.Year;
        return age;*/
        return yearNow - BirthDay.Year;
    }
    
    public string GetFullName()
    {
        return LastName + " " + Name + " " + MiddleName;
    }
    
    public void PrintFullName()
    {
        Console.WriteLine(GetFullName());
    }
    
        
    public string GetShortFullName()
    {
        return LastName + " " + Name.First() + "." + MiddleName.First()+".";
    }
}