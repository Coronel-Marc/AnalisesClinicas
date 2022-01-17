
using System;

namespace Laboratorio
{
    class Program
    {
        
        static int contPe = 0;
        public static int contP = 0;
        static int contM = 0;
        static int contC = 0;
        public static int contGe = 0;
        static int contEx = 0;
        static int contPexe = 0;

        static Paciente[] p = new Paciente[10];
        static Medico[] m = new Medico[10];
        static Convenio[] c = new Convenio[10];
        static PedidoExame[] pe = new PedidoExame[10];
        static GrupoExame[] ge = new GrupoExame[10];
        static Exame[] ex = new Exame[10];
        static ExamePedidoExame[] pexe = new ExamePedidoExame[10];
        static void Main(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                 Console.WriteLine("------------------------");
                 Console.WriteLine("SISTEMA ANALISES CLINICAS");
                 Console.WriteLine("------------------------");
                 Console.WriteLine("|PACIENTE       [1 - Cadastrar] [2 - Listar] |");
                 Console.WriteLine("|CONVÊNIO       [3 - Cadastrar] [4 - Listar] |");
                 Console.WriteLine("|MÉDICO         [5 - Cadastrar] [6 - Listar] |");
                 Console.WriteLine("|PEDIDO EXAME   [7 - Cadastrar] [8 - Listar] |");
                 Console.WriteLine("|EXAME          [9 - Cadastrar] [10 - Listar] |");
                 Console.WriteLine("|GRUPO EXAME    [11 - Cadastrar] [12 - Listar] |");
                 Console.WriteLine("------------------------");
                 Console.WriteLine("| 0 - Sair |");
                 Console.WriteLine("Escolha uma opção: ");
                 opcao = Convert.ToInt32(Console.ReadLine());

                 switch (opcao)
                 {
                     case 1:
                    p[contP] = new Paciente();
                    p[contP].cadastrar();
                    contP++;
                        break;

                     case 2:
                    imprimePaciente();
                        break;

                     case 3:
                    c[contC] = new Convenio();
                    c[contC].cadastrar();
                        break;

                     case 4:
                    imprimeConvenio();
                        break;

                     case 5:
                    m[contM] = new Medico();
                    m[contM].cadastrar();
                    contM++;
                        break;

                     case 6:
                    imprimeMedico();
                        break;

                     case 7:
                     pe[contPe] = new PedidoExame();
                     pe[contPe].cadastrar();
                     contPe++;

                     int resp = 1;
                     while(resp == 1)
                     {
                        pexe[contPexe] = new ExamePedidoExame();
                        pexe[contPexe].cadastrar();
                        contPexe++;
                        Console.WriteLine("Deseja cadastrar outro exame? [1 - Sim] [2 - Não]: ");
                        resp = Convert.ToInt32(Console.ReadLine());
                     }
                        break;

                     case 8:
                     imprimePedidoExame();
                        break;

                     case 9:
                     ex[contEx] = new Exame();
                     ex[contEx].cadastrar();
                        break;

                     case 10:
                     imprimeExame();
                        break;

                     case 11:
                     ge[contGe] = new GrupoExame();
                     ge[contGe].cadastrar();
                        break;

                     case 12:
                     imprimeGrupoExame();
                        break;

                     default:
                     return;
                 }
            }
        }

        private static void imprimePaciente()
        {
            for (int i = 0; i < contP; i++)
            {
                Console.WriteLine(i);
                p[i].imprimirPaciente();
                Console.WriteLine("----------------------------");
            }
        }

        private static void imprimeConvenio()
        {
            for (int i = 0; i < contC; i++)
            {
                c[i].imprimirConvenio();
                Console.WriteLine("----------------------------");
            }
        }

        private static void imprimeMedico()
        {
            for (int i = 0; i < contM; i++)
            {
                m[i].imprimirMedico();
                Console.WriteLine("----------------------------");
            }
        }
        private static void imprimePedidoExame()
        {
            for (int i = 0; i < contP; i++)
            {
                pe[i].imprimirPedidoExame();
                Console.WriteLine("----------------------------");

                for (int j = 0; j < contPexe; j++)
                {
                    pexe[j].imprimir();
                    Console.WriteLine("----------------------------");
                }
            }
                
        }

        private static void imprimeGrupoExame()
        {
            for (int i = 0; i < contGe; i++)
            {
                ge[i].imprimirGrupoExame();
                Console.WriteLine("----------------------------");
            }
        }

        private static void imprimeExame()
        {
            for (int i = 0; i < contEx; i++)
            {
                ex[i].imprimirExame();
                Console.WriteLine("----------------------------");
            }
        }
    
    }
}