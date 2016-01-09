using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject person = JObject.Parse(@"{'name':'David','otherData':'Hello World :D'}");

            string printerLine = person["name"].ToString();
            Console.WriteLine(printerLine);
            Console.ReadLine();
        }
    }
}
