using System;
  
  class Person
  {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        
        

        public Person() 
        {
          
          Console.WriteLine("Person constructor");
        }

        public Person(string fname, string lname) 
        {
          FirstName = fname;
          LastName = lname;
          
          Console.WriteLine("Person constructor");
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is *** "+ FirstName +" "+ LastName);
            
        }

        public void IsBirthday()
        {
          if ((DateTime.Today.Month == DateOfBirth.Month)&&(DateTime.Today.Day == DateOfBirth.Day))
            Console.WriteLine("It's your birthday!!!");
          else
            Console.WriteLine("Today is not your birthday.");
        }

      
    }