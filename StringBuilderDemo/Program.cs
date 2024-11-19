using System;
using System.Text;
using static StringBuilderDemo.CustomException;


namespace StringBuilderDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //code for string builder
            /* char[] ch = new char[5];
             StringBuilder sb = new StringBuilder("Hello");
             Console.WriteLine(sb);
             Console.WriteLine(sb.GetHashCode());
             Console.WriteLine("Length:"+sb.Length);
             Console.WriteLine("Capacity:"+sb.Capacity);

             //To modify data/string in the class we have Append method
             sb.Append(" Good Morning");
             Console.WriteLine(sb);
             sb.Replace("Hello", "Hi");
             Console.WriteLine(sb);
             // sb.Remove(3, 5);
             //sb.Clear();

             sb.CopyTo(0, ch, 0, 5);
             foreach (var item in ch)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine(sb);
             string str1 = String.Join("", ch);
             sb.Append(str1);
             Console.WriteLine(sb);
             Console.WriteLine(sb.GetHashCode());
             Console.WriteLine("Length:" + sb.Length);
             Console.WriteLine("Capacity:" + sb.Capacity);
            */

            //code for custom exception
            try
            {
                User user = new User(17);
                //User user = new User(25);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                //User user = new User(null);
                User user = new User("");
                //User user = new User("Kshitija");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
