using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3 {
    class Program {
        public static void Main(string[] args) {
            string stringa = Console.ReadLine();
            Console.WriteLine();
            char[] charSeparators = new char[] {',', ' ', '.', ':', '\n', ';'};
            string[] a;
            a = stringa.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
			bool b = false;
			do {
				b = false;
				for (int i=1; i<a.Length; i++) {
					if (i>0) {
						if (a[i].CompareTo(a[i-1])<0) {
							string s = a[i];
							a[i] = a[i-1];
							a[i-1] = s;
							b = true;
						}		
					}
				}
			} while (b==true);
            Console.WriteLine("Ecco la lista sortata:");
            for (int i=0; i<a.Length; i++) {
		        Console.WriteLine(a[i]);
            }
            Console.ReadLine();
		}
    }
}
