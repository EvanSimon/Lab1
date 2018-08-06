using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1, number2, ans1 = 0, ans2 = 0, i;
          //  string input1, input2;
           // bool input1Pars, input2Pars;



          
                Console.WriteLine("Enter the your first intiger:");
               number1 = int.Parse(Console.ReadLine());
               


                Console.WriteLine("Enter your second intiger:");
                number2 = int.Parse(Console.ReadLine());
               

            for (i = 0; number1 != 0 && number2 != 0; i++)
            {
                if (ans1 == ans2)

                {
                  
                    ans1 = number1 % 10 + number2 % 10;
                    number1 = number1 / 10;
                    number2 = number2 / 10;
                    ans2 = number1 % 10 + number2 % 10;

                }


            

                else
                {
                    Console.WriteLine("flase");
                    break;
                }

            }
            if (number1 == 0 && number2 == 0) 
            {
                Console.WriteLine("true");
            }



        
           
          }
    }
}
