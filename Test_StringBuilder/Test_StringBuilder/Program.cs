using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Test_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More important text here", 256);
            Console.WriteLine("Cacacity : {0}", sb.Capacity);
            Console.WriteLine("Cacacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb.Length);
            Console.WriteLine("Length : {0}", sb2.Length);
            sb2.AppendLine("\ntext here");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("En-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer :{0}", bestCust);

            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "Characters");
            //Console.WriteLine(sb2.ToString());


            int [] minArray = {0,1,2,3,4,5 };
            Console.WriteLine(minArray.Length + " elements");
            Console.WriteLine(minArray.Count() + " elements");
            for (int i = 0; i < minArray.Length; i++)
            {
                Console.WriteLine(i + "");
            }

            //sb2.Clear();
            //sb.Append("Random text");
            //Console.WriteLine(sb.Equals(sb2));
            //sb2.Insert(14, " That's great");
            //Console.WriteLine(sb2.ToString());

            Console.ReadLine();
        }
    }
}
