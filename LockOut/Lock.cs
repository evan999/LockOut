using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockOut
{
    public class Lock
    {
        public bool incorrectPasscodeAttempts(string passcode, string[] attempts)
        {
            int maxAttempts = 10;
            bool lockOut = false;
            int consecAttempts = 1;

            for (int numAttempts = 1; numAttempts < attempts.Length; numAttempts++)
            {
                if (consecAttempts == 10)
                {
                    lockOut = true;
                    Console.WriteLine("Account has been locked out. Max attempts reached." );
                    break;
                }

                if (passcode == attempts[numAttempts])
                { 
                    consecAttempts = 1;
                }
                else
                {
                    consecAttempts++;
                }


            }

            return lockOut;
        }

    }
}
