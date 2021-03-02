using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodAssignment
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string FirstName = "anand";
            string result = Entensionhelper.CreateUpperCase(FirstName);
            string resultobj = Entensionhelper.CreateLowerCase(FirstName);
            string answer = Entensionhelper.Converttoint(FirstName);
            Console.WriteLine(result);
            Console.WriteLine(resultobj);
            Console.WriteLine(answer);
        }
    }
}
