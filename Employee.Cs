using System;

class Employee : Person {
      private int hoursWorkedPerDay;
      public double YearlySalary {get; set;}
      public string Title {get; set;}      
      public int Id {get; set;}
      public  DateTime DateOfJoining { get; set; }
      
      public override string PhoneNumber { 
        get{
          return base.PhoneNumber;
        }
        set {
            if (value.Length != 10)
              Console.WriteLine("Invalid phone number");
            else
              base.PhoneNumber = value;
        }
      }
    public Employee() : base()
    {
        YearlySalary = 1000;
        Title = "Level 1 employee";
        Console.WriteLine(YearlySalary);
         Console.WriteLine(Title);
    }


    public Employee(string firstname, string lastname,double salary, string title) : base(firstname, lastname)
    {
        YearlySalary = salary;
        Title = title;
        Console.WriteLine(YearlySalary);
        Console.WriteLine(Title);
    }

    public override void Intro()
    {
      base.Intro();      
      Console.WriteLine("Employee since " + DateOfJoining.Year);
      Console.WriteLine("Title " + Title);
    }
    

}