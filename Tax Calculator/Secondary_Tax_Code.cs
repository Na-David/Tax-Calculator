using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    public class Secondary_Tax_Code
    {
        bool Tax_SBSL = false;
        bool Tax_SB = false;
        bool Tax_SSL = false;
        bool Tax_S = false;
        bool Tax_SHSL = false;
        bool Tax_SH = false;
        bool Tax_STSL = false;
        bool Tax_ST = false;

        public void secondary_income_tax_code()
        {
            Console.WriteLine("Is your annual income from all source likely to be $14,000 or less?");
            Console.WriteLine("1. Yes 2. No");
            int second_source = int.Parse(Console.ReadLine());

            if (second_source == 2)
            {
                Console.Clear();
                Console.WriteLine("Is your annual income from all soures likely to be between $14,001 - $48,000?");
                Console.WriteLine("1. Yes 2. No");
                int annual_income = int.Parse(Console.ReadLine());

                if (annual_income == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Is your annual income from all sources likely to be between $48,001 - $70,000?");
                    Console.WriteLine("1. Yes 2. No");
                    int annual_income2 = int.Parse(Console.ReadLine());

                    if(annual_income2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a student loan?");
                        Console.WriteLine("1. Yes 2. No");
                        int loan = int.Parse(Console.ReadLine());

                        if (loan == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is ST SL");
                            Console.ReadKey();
                            Tax_STSL = true;
                        } else if (loan == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is ST");
                            Console.ReadKey();
                            Tax_ST = true;
                        }

                    } else if(annual_income2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a student loan?");
                        Console.WriteLine("1. Yes 2. No");
                        int loan = int.Parse(Console.ReadLine());

                        if (loan == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is SH SL");
                            Console.ReadKey();
                            Tax_SHSL = true;
                        }
                        else if (loan == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Your tax code is SH");
                            Console.ReadKey();
                            Tax_SH = true;
                        }

                    }
                } else if(annual_income == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Do you have a student loan?");
                    Console.WriteLine("1. Yes 2. No");
                    int loan = int.Parse(Console.ReadLine());

                    if (loan == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Your tax code is S SL");
                        Console.ReadKey();
                        Tax_SSL = true;
                    }
                    else if (loan == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Your tax code is S");
                        Console.ReadKey();
                        Tax_S = true;
                    }
                }
            } else if (second_source == 1)
            {
                Console.Clear();
                Console.WriteLine("Do you have a student loan?");
                Console.WriteLine("1. Yes 2. No");
                int loan = int.Parse(Console.ReadLine());

                if (loan == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Your tax code is SB SL");
                    Console.ReadKey();
                    Tax_SBSL = true;
                }
                else if (loan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Your tax code is SB");
                    Console.ReadKey();
                    Tax_SB = true;
                }

            }

        }
    }
}
