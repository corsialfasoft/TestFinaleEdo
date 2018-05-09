using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esercizio2 {
    class Program {
        static void Main(string[] args) {
            int[] count;
            string frase = Console.ReadLine();
            char[] charSeparators = new char[] {',', ' ', '.', ':', '\n', ';'};
            string[] parole;
            parole = frase.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(parole, StringComparer.InvariantCulture);
            count = new int[parole.Length];
            int j = 0;
            for (int i = 1; i<parole.Length; i++) {
                if (parole[i].CompareTo(parole[i-1])==0) {
                    count[j]++;
                } else {
                    j++;
                }
            }
            j=0;
            for (int i = 1; i<parole.Length; i++) {
                if (parole[i].CompareTo(parole[i-1])!=0) {
                    Console.WriteLine($"{parole[i-1]}: {count[j]+1}");
                    j++;
                }
            }
            Console.WriteLine($"{parole[parole.Length-1]}: {count[j]+1}");
            Console.ReadLine();
        }
    }
}