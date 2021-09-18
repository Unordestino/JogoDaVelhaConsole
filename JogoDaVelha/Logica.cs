using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha {
    class Logica {
        public string Jogador_Atual = "X";
        public Boolean Continue = true;
        Visual v = new Visual();


        public string InverterJogador() {
            if (Jogador_Atual == "X") {
                return "0";
            } else {
                return "X";
            }
        }

        public void VelhaJogador() {
            v.Matriz();
          
            while (Continue) {
                int.TryParse(Console.ReadLine(), out int op);
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        if (v.Triz[i, j] == op.ToString()) {
                            v.Triz[i, j] = Jogador_Atual;
                            Jogador_Atual = InverterJogador();
                            
                            if (VerificarX() == true) {
                                Continue = false;
                            } 

                        } 

                    }
                }
                Console.Clear();
                v.Desing();
                JogadorAtual();
                VelhaPc();
            }

        }

        public void JogadorAtual() {
            Console.SetCursorPosition(1, 8);
            Console.WriteLine("Jogador Atual: " + Jogador_Atual);
        }

        public void Ganhar() {
            Console.WriteLine("O jogador " + Jogador_Atual + " ganhou!");
        }

        public bool VerificarX() {
            if (v.Triz[0,0] == "X" && v.Triz[1, 1] == "X" && v.Triz[2, 2] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 2] == "X" && v.Triz[1, 1] == "X" && v.Triz[2, 0] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 0] == "X" && v.Triz[0, 1] == "X" && v.Triz[0, 2] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[1, 0] == "X" && v.Triz[1, 1] == "X" && v.Triz[1, 2] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[2, 0] == "X" && v.Triz[2, 1] == "X" && v.Triz[2, 2] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 0] == "X" && v.Triz[1, 0] == "X" && v.Triz[2, 0] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 1] == "X" && v.Triz[1, 1] == "X" && v.Triz[2, 1] == "X") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 2] == "X" && v.Triz[1, 2] == "X" && v.Triz[2, 2] == "X") {
                Ganhar();
                return true;
            }
            return false;
        }

        public bool Verificar0() {
            if (v.Triz[0, 0] == "0" && v.Triz[1, 1] == "0" && v.Triz[2, 2] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 2] == "0" && v.Triz[1, 1] == "0" && v.Triz[2, 0] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 0] == "0" && v.Triz[0, 1] == "0" && v.Triz[0, 2] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[1, 0] == "0" && v.Triz[1, 1] == "0" && v.Triz[1, 2] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[2, 0] == "0" && v.Triz[2, 1] == "0" && v.Triz[2, 2] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 0] == "0" && v.Triz[1, 0] == "0" && v.Triz[2, 0] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 1] == "0" && v.Triz[1, 1] == "0" && v.Triz[2, 1] == "0") {
                Ganhar();
                return true;
            }
            if (v.Triz[0, 2] == "0" && v.Triz[1, 2] == "0" && v.Triz[2, 2] == "0") {
                Ganhar();
                return true;
            }
            return false;
        }

        public void VelhaPc() {
            if (v.Triz[0, 0] != "1" && v.Triz[0, 1] != "2" && v.Triz[0, 2] != "3" 
                && v.Triz[1, 0] != "4" && v.Triz[1, 1] != "5" && v.Triz[1, 2] != "6"
                && v.Triz[2, 0] != "7" && v.Triz[2, 1] != "8" && v.Triz[2, 2] != "9") {
                Console.Clear();
                Console.WriteLine("Deu Velha!");
                Console.Write("Digite 1 para Continuar ou 2 para Sair: ");
                int.TryParse(Console.ReadLine(), out int op);

                switch (op) {
                    case 1:
                        Jogador_Atual = "X";
                        Console.Clear();
                        v.Matriz();
                        v.Desing();
                        VelhaJogador();
                        break;
                    case 2:
                        Continue = false;
                        break;
                }

            }

   

        }

    }
}
