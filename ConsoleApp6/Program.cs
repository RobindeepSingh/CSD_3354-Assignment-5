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
            a.Run(57);
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
            for (int i = 0; i < LEN; i++) { ListQ.Add(r.Next(100)); }
            this.findTwoNumbersThatAddUpTo(AddUpToNumber);
            foreach (int i in ListQ)
            {
                Console.WriteLine(i);
            }
           
        }
        public void findTwoNumbersThatAddUpTo(int addUpToNumber)
        {


        }
    }


}  
