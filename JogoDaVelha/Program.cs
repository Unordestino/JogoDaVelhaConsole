using System;

namespace JogoDaVelha {
    class Program {
        static void Main(string[] args) {
            Logica l = new Logica();
            Visual v = new Visual();
            v.Matriz();
            v.Desing();
            l.VelhaJogador();

        }
    }
}
