using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyServiceStack.ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\idamiani\Desktop\SampleData.json";

            IReader reader = new Option3Reader();
            var el1 = reader.GetAllFromFile(filename).ElementAt(4500);

            AlternativeElement ae = el1;
            Element el2 = ae;
        }
    }
}