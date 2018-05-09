using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1 {
    class Program {
        static void Main(string[] args) {
            for (int i=1; i<=15; i++) {
                Console.WriteLine(2*i);
            }
            Console.WriteLine();
            for (int i=15; i>=1; i--) {
                Console.WriteLine(2*i-1);
            }
            Console.ReadLine();
        }
    }
}
