using NUnit.Framework;
using System;

namespace ATUniversityAdvancedCourse
{
    //Class Named Person
    public class Person
        //Person Class has name, age, canWalk private fields
    {
        private string name;
        private int age;
        private bool canWalk;
        private bool result;

        //Constructor that sets persons name
        public Person()
        {
            name = "Jeannine";
        }

        //Person class has attributes: Age(int), get returns age value
        //Set routine: set age value if less than 2 or greater than 89.  Sets can Walk flag to false, else true   
        public int Age {  get; set; }
        
        public int AgeValue
        {
            get 
            { 
                return age; 
            }
            set
            {
                if (value < 2 || value > 89) 
                {
                    Age = value;
                    canWalk = false;                        
                }
                
                else
                {
                    canWalk = true;
                }
            }      
        }

        /*Equal method(gets an object of a parameter) Equal will return a bool flag in case object received was a person with same name
        and age , use try catch finall block to validate object received is person type */
        
        
        public bool sameNameAge()
        {
            
            try
            {
                Person a = new Person();
                Person b = a;
                a.Equals(b); //true

                name = b.name;
                age = b.Age;

            }
            catch (Exception)
            {
                Console.WriteLine("Person Found with same name and age found");
                result = true;
                
            }
            finally
            {
                Console.Write("Thank you, have a nice day");
            }
            return result;
        }
        
         
    }
}