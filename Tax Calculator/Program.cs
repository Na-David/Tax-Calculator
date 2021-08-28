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
            Secondary_Tax_Code Secondary_Code = new Secondary_Tax_Code();
            Tax_Payable Tax_payable = new Tax_Payable();

            Console.WriteLine("**********************************************");
            Console.WriteLine("*************** Tax Calculator ***************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");

             Primary_Code.primary_income_tax_code();


            Console.WriteLine("Do you have a secondary income source?");
            Console.WriteLine("1. Yes 2. No");
            int secondary_income_source = int.Parse(Console.ReadLine());

            if (secondary_income_source == 1)
            {
                Secondary_Code.secondary_income_tax_code();
            } else if (secondary_income_source == 2)
            {
                Tax_payable.tax_payable();
            }

            /////////////////////////////////////////////////////

        }
    }
}
