using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    class Tax_Payable
    {
        public void tax_payable()
        {
            Console.WriteLine("Please input your primary income.(without $ sign)");
            int primary_income = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input your secondary income. (without $ sign)");
            Console.WriteLine("If you don't have a secondary income, then input '0'.");
            int secondary_income = int.Parse(Console.ReadLine());

            int annual_income = primary_income + secondary_income;

            


        }
    }
}
