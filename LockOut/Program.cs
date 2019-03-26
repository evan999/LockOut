using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] attempts = { "1111", "4444", "9999", "3333", "8888", "2222", "7777", "0000", "6666", "7285", "5555", "1111" };
            Lock lock1 = new Lock();
            var result = lock1.incorrectPasscodeAttempts("1111", attempts);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
