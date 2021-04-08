using System;

class MainClass {
  public static void Main (string[] args) {
    
     Console.WriteLine("Person object");
    Person p1 = new Person("John","Smith");
    p1.DateOfBirth = Convert.ToDateTime("01/01/1999");
    p1.Email = "abc@yahoo.com";
    p1.PhoneNumber = "1";
    p1.Intro();
    Console.WriteLine("Person object ends");
    

    Employee e1 = new Employee();
    e1.DateOfBirth = Convert.ToDateTime("01/01/1980");
    e1.Intro();


    Employee e2 = new Employee("John", "Smith", 100000, "Level 2 Employee");
    e2.DateOfBirth = Convert.ToDateTime("01/01/1980");
    e2.DateOfJoining = Convert.ToDateTime("01/01/2021");
    e2.PhoneNumber="1";
    e2.Intro();
    e2.IsBirthday();

  }
}