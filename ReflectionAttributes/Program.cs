//RTTI -> runtime type information
using System.Reflection;

namespace ReflectionAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arg = 100;
            string s = $"Sqrt({arg})";
            string methodName = s.Substring(0, s.IndexOf('('));
            
            // Step 1: Get type of Class (Struct) wich method we are going to call
            Type type = typeof(Math);

            // Step 2: Finde the method by name
            //MethodInfo? mi = type.GetOneParameterMethod(methodName);
            MethodInfo? mi = type.GetMethod(methodName);

            if (mi == null)
            {
                Console.WriteLine("Methot not found ");
                return;
            }
            
            // Step 3 : Call the method (via methodinfo class)
            // arguments of invoke :
            //   1.instance for wich the method is called // null for static methods
            //   2.list of argument of thet method

            object? rezult = mi.Invoke(null, new object[] { arg });

            double ? d = rezult as double?;
            Console.WriteLine(d);
        }
    }
}













