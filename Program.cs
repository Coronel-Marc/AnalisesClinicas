
using System;
using Laboratorio.Models;

namespace Laboratorio
{
    class Program
    {
        
        static int contPe = 0;
        static int contP = 0;
        static int contM = 0;
        static int contC = 0;
        static int contGe = 0;
        static int contEx = 0;
        static int contPexe = 0;
        static void Main(string[] args)
        {
            Paciente[] pacientes = new Paciente[10];
            Medico[] medicos = new Medico[10];
            Convenio[] convenios = new Convenio[10];
            PedidoExame[] pedidoExames = new PedidoExame[10];
            GrupoExame[] grupoExames = new GrupoExame[10];
            Exame[] exames = new Exame[10];
            ExamePedidoExame[] examePedidoExames = new ExamePedidoExame[10];
             

        }

        static void imprimePaciente()
        {
            for (int i = 0; i < contP; i++)
            {
                Console.WriteLine(i);
                p[i].imprimirPaciente();
                Console.WriteLine("----------------------------");
            }
        }

        static void imprimeConvenio()
        {
            for (int i = 0; i < contC; i++)
            {
                c[i].imprimirConvenio();
                Console.WriteLine("----------------------------");
            }
        }
    
    }
}