using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    class Primary_Tax_Code
    {
        Secondary_Tax_Code second_tax_code = new Secondary_Tax_Code();

        bool Tax_M = false;
        bool Tax_ME = false;
        bool Tax_MESL = false;
        bool Tax_MSL = false;

        public void primary_income_tax_code()
        {

            Console.WriteLine("Do you receive an income tested benefit?");
            Console.WriteLine("1. Yes 2. No");
            int tested_benefit = int.Parse(Console.ReadLine());

            if (tested_benefit == 1)
            {
                Console.Clear();
                Console.WriteLine("Is this tax code for the income tested benefit?");
                Console.WriteLine("1. Yes 2. No");
                int tested_benefit2 = int.Parse(Console.ReadLine());
                if (tested_benefit2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Your tax code is M");
                    Tax_M = true;
                }
                else if (tested_benefit2 == 2)
                {
                    // secondary income
                    second_tax_code.secondary_income_tax_code();
                }
            }
            else if (tested_benefit == 2)
            {
                Console.Clear();
                Console.WriteLine("Is this tax code for your main or highest source of income?");
                Console.WriteLine("1. Yes 2. No");
                int highest_income = int.Parse(Console.ReadLine());

                if (highest_income == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Are you a New Zealand tax resident?");
                    Console.WriteLine("1. Yes 2. No");
                    int NZ_tax_resident = int.Parse(Console.ReadLine());

                    if (NZ_tax_resident == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Is your annual income likely to be between $24,000 - $48,000?");
                        Console.WriteLine("1. Yes 2. No");
                        int annual_income = int.Parse(Console.ReadLine());

                        if (annual_income == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Are you or your partner entitled to working for Families Tax Credits or \nAn overseas equivalent or do you receive NZ Super, veteran's pension or \nAn overseas equivalent?");
                            Console.WriteLine("1. Yes 2. No");
                            int overseas = int.Parse(Console.ReadLine());

                            if (overseas == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Do you have a New Zealand student loan?");
                                Console.WriteLine("1. Yes 2. No");
                                int loan = int.Parse(Console.ReadLine());

                                if (loan == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your tax code is ME SL");
                                    Console.ReadKey();
                                    Tax_MESL = true;
                                }
                                else if (loan == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your tax code is ME");
                                    Console.ReadKey();
                                    Tax_ME = true;
                                }
                            }
                            else if (overseas == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Do you have a New Zealand student loan?");
                                Console.WriteLine("1. Yes 2. No");
                                int loan = int.Parse(Console.ReadLine());

                                if (loan == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your tax code is M SL");
                                    Console.ReadKey();
                                    Tax_MSL = true;
                                }
                                else if (loan == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your tax code is M");
                                    Console.ReadKey();
                                    Tax_M = true;
                                }

                            }
                        }
                        else if (annual_income == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Do you have a New Zealand student loan?");
                            Console.WriteLine("1. Yes 2. No");
                            int loan = int.Parse(Console.ReadLine());

                            if (loan == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Your tax code is M SL");
                                Console.ReadKey();
                                Tax_MSL = true;
                            }
                            else if (loan == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Your tax code is M");
                                Console.ReadKey();
                                Tax_M = true;
                            }

                        }
                    }
                    else if (NZ_tax_resident == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a New Zealand student loan?");
                        Console.WriteLine("1. Yes 2. No");
                        int loan = int.Parse(Console.ReadLine());

                        if (loan == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is M SL");
                            Console.ReadKey();
                            Tax_MSL = true;
                        }
                        else if (loan == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is M");
                            Console.ReadKey();
                            Tax_M = true;
                        }
                    }
                }
                else if (highest_income == 2)
                {
                    // secondary income
                    second_tax_code.secondary_income_tax_code();
                }
            }

        }

    }
}
