using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoFakeAPI
{
    internal class Program
    {
        public static int Areacircle(int x)
        {
            if (x == 2)
            {
                return 2;
            }
            else
                return 4;
        }

        public static void main(String args[])
        {
            Areacircle(2);
        }
    }
}
