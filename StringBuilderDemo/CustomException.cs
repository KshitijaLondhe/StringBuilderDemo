using System;
using System.Text;
namespace StringBuilderDemo
{
    public class CustomException:Exception
    {
       
        public CustomException(string msg) : base(msg)
        {

        }
        public class User
        {
            private int age;
            private string name;

            public User(int age)
            {
                if (age >= 18)
                {
                    this.age = age;
                    Console.WriteLine("Age :"+age);
                }
                else
                {
                    throw new CustomException(age + " is not allowed");
                    //explicit call to exception using throw keyword
                }
            }
            public User(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new CustomException("Empty name is not allowed");
                }
                else
                {
                    this.name = name;
                    Console.WriteLine("Name :" + name);
                }
            }
        }
    }
}
