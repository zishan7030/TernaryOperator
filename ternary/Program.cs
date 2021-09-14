using System;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int withdrawl;
            int balance = 10000;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Your Account has {0} Amount", balance);
            Console.WriteLine("Enter Your Amount");
            withdrawl = Convert.ToInt32(Console.ReadLine());
            

            balance = (withdrawl > balance )? (balance) :( balance -withdrawl);

            Console.WriteLine("Your Balance is " + balance);

        }
    }
}
