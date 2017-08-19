using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("pt-BR");

            string[] formats = new string[] { "dd/MM/yyyy"
                , "yyyy-MM-dd"
                , "dd-MM-yyyy"
                , "dd/MM/yyyyTHH:mm"
                , "dd/MM"
                , "dddd, d 'de' MMMM 'de' yyyy" 
            };

            string[] dates = new string[] { "14/05/2014"
                , "2013-07-20"
                , "20-10-2013"
                , "21/02/2014T17:17"
                , "24/04"
                , "sexta-feira, 7 de março de 2014" 
            };

            foreach (string date in dates)
                System.Console.WriteLine(DateTime.ParseExact(date, formats, cultureInfo, System.Globalization.DateTimeStyles.None));

            System.Console.WriteLine(Convert.ToDateTime("2014-08-11T17:14:05-03:00"));
            
            System.Console.ReadKey();
        }
    }
}
