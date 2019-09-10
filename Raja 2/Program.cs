using System;

namespace Raja2
{

    class Program

    {

        static void Main(string[] args)

        {

            int num1;

            int num2;

            string operand;

            float answer;



            Console.Write("please enter the first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());



            Console.Write("Please enter an operand (+,-,/,*): ");



            operand = Console.ReadLine();



            Console.Write("please enter the second number: ");



            num2 = Convert.ToInt32(Console.ReadLine());



            switch (operand)

            {

                case "-":



                    answer = num1 - num2;



                    break;



                case "+":



                    answer = num1 + num2;



                    break;



                case "/":



                    answer = num1 / num2;

                    break;



                case "*":



                    answer = num1 * num2;



                    break;



                default:

                    answer = 0;



                    break;





            }



            Console.WriteLine(num1.ToString() + " " + num2.ToString() + " = " + answer.ToString());



            _ = Console.ReadLine();



        }
    }

}












