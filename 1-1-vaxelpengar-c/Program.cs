using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Resources;

namespace _1_1_vaxelpengar_c
{
    class Program
    {

        // Testar att skicka till github


        //public virtual string GetString(
        //        string Strings
        //    );

        static void Main(string[] args)
        {
            uint subtotal;

            subtotal = (uint)ReadPositiveDouble("Skriv in summa:"); 
            ReadUint("Erhållet belopp:", subtotal); 
        }

        static double ReadPositiveDouble(string prompt)
        {
         double subtotal;

         Console.Write(prompt);
         subtotal = double.Parse(Console.ReadLine());
         return subtotal; 
        }

        static uint ReadUint(string prompt, uint minValue)
        {
            uint recievedMoney;

            Console.Write(prompt);
            recievedMoney = uint.Parse(Console.ReadLine());
            return recievedMoney;
        }

        static uint[] SplitIntoDenominations(uint change, uint[] denominations)
        {
            throw new NotImplementedException();
        }

        static void ViewMessage(string message) //static void ViewMessage(string message [bool isError = false])
        {
        }

        static void ViewReciept(double roundingOffAmount, uint total, uint cash, uint change, uint[] notes, uint[] denominations)
        {
            throw new NotImplementedException();
        }
    }
}
