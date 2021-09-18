using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha {
    class Visual {
        public string[,] Triz = new string[3, 3];
        public void Matriz() {
            int cont = 1;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Triz[i, j] = cont.ToString();
                    cont++;

                }

            }
        }

        public void Desing() {
            Console.WriteLine("---------------");
            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 3; j++) {
                    Console.Write(" " + Triz[i, j] + "    ");
                }
                Console.WriteLine("\n---------------");

            }

            for (int i = 0; i < 7; i++) {
                Console.SetCursorPosition(14, i);
                Console.Write("|");
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }
            Console.WriteLine("\n\n");
        }

    }
}
