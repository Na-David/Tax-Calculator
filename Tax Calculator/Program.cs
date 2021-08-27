using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum CODE
{
    M, MSL, ME, MESL, SB, SBSL, S, SSL, SH, SHSL, ST, STSL
}

namespace Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Primary_Tax_Code Primary_Code = new Primary_Tax_Code();

            Console.WriteLine("**********************************************");
            Console.WriteLine("*************** Tax Calculator ***************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");


            Primary_Code.primary_income_tax_code();
        }
    }
}
