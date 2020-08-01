using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadSpace
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Thread t = new Thread(print1);
            t.start();
            for(int i=0; i< 500; i++)
            {
                Console.WriteLine(i);
            }
        
            //Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            int num = 0;
            for(int i=0; i< 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("end of thread");
        
            //Console.ReadLine();
        }
        */
        static void Main()
        {
            BankAcct acct = new BankAcct(5);
            Thread[] threads = new Thread[15];
            Thread.CurrentThread.Name = "Main";

            for(int i=0; i<15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] =  t;
            }

            for(int i=0; i<15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            }
        }

        static void print1()
        {
            for(int i=0; i<500; i++)
            {
                Console.Write(1);
            }
        }

        class BankAcct
        {
            private Object accLock = new object();
            double Balance {set; get;}
            public BankAcct(double bal)
            {
                Balance = bal;
            }
            public double Withdraw(double amt)
            {
                if((Balance - amt) < 0)
                {
                    Console.WriteLine($"Sorry {Balance}€ in Account");
                    return Balance;
                }
                //? not realy understand of thread
                lock(accLock)
                {
                    if(Balance >= amt)
                    {
                        Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
                        Balance -= amt;
                    }
                    return Balance;
               }
            }
            public void IssueWithdraw()
            {
               double total =  Withdraw(1);
               Console.WriteLine("{0}€ left in account : ",total);
            }
       
        }
    }


}