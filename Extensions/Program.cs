using System;

class Student
{
    int id;
    string name;

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return "Name: " + Name + '\n'+ "ID: " + ID.ToString();
    }
}

static class TestStudent
{
    static void Main(string[] args)
    {
        /*
        Student smartStudent = new Student();
        smartStudent.Name = "Albert Einstein";
        smartStudent.ID = 001;

        Student smartCopy = smartStudent.copyStudent();

        Console.WriteLine(smartStudent.ToString());
        Console.WriteLine(smartCopy.ToString());
        */

        int accNum = 40001;
        int revisedAccNum = accNum.AddCheckDigit();
        Console.WriteLine(accNum);
        Console.WriteLine(revisedAccNum);

    }

    /*extension methods*/
    public static Student copyStudent(this Student a)
    {
        Student b = new Student();
        //b.Name = "Master Cheif";
        //b.ID = 117;
        b.ID = a.ID;
        b.Name = a.Name;

        return b;
    }

    public static int AddCheckDigit(this int x)
    {
        int first = x / 10;
        int second = x % 10;
        int third = (first + second) % 10;
        int result = x * 10 + third;

        return result;
    }
}
