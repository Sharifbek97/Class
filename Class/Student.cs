namespace Class;

public class Student
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string MidleName { get; set; }
    public DateTime BirthDay { get; set; }

    
    public int GetAge()
    {
        return DateTime.Now.Year - BirthDay.Year;
    }

    public string GetFullName()
    {
        return $"{SurName} {Name} {MidleName}";
    }
    public string GetShortName()
    {
        return $"{SurName} {Name.First()}.{MidleName.First()}.";
    }
    public void GetPrintStudent(int Age, string fullName, string ShortName)
    {
        Console.WriteLine("\n\tFullName: "+fullName+"\n\tShortName: "+ShortName+"\n\tBirthDay:"+BirthDay+
                          "\n\tAge: "+Age);
       
    }
}


