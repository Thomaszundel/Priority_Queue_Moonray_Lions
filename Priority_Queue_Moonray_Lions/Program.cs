using System;

namespace Priority_Queue_Moonray_Lions
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue PriorityQue = new ERQueue();
            Patient First = null;
            Patient Last = null;
           

            void PrintMenu()
            {
               
                Console.WriteLine("Patient Queue");
                Console.WriteLine("(A)dd Patient");
                Console.WriteLine("(P)rocess Current Patient");
                Console.WriteLine("(L)ist All in Queue");
                Console.WriteLine("(Q)uit");
                
            }
        }
    }
}
