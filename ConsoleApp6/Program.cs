using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            new GenerateList().Run(57);
           
        }
    }
    class GenerateList
    {

        const int LEN = 100;
        ArrayList ListQ;
        public void Run(int AddUpToNumber)
        {
            Random r = new Random();

            ListQ = new ArrayList();
            for (int i = 0; i < LEN; i++)
            {
                ListQ.Add(r.Next(100));
                this.findTwoNumbersThatAddUpTo(AddUpToNumber);
                break;
            }
            
           
        }
        public void findTwoNumbersThatAddUpTo(int a)
        {
            Random r = new Random();

            ListQ = new ArrayList();
            int e1 = 0;
            int e2 = 0;
            for (int i = 0; i < LEN; i++)
            {
                int w1 = ListQ.Add(r.Next(100));
                int w2 = ListQ.Add(r.Next(100));
                if (w1 + w2 == a)
                {
                    e1 = w1;
                    e2 = w2;
                    Console.WriteLine(e1 + " " + e2);
                }
            }

        }

    }
  }



