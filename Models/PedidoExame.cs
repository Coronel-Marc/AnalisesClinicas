
namespace Laboratorio.Models
{
    public class PedidoExame
    {
        private int codigo;
        private Paciente paciente = new Paciente();
        private Medico medico = new Medico();
        private Convenio convenio = new Convenio();

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public Paciente GetPaciente()
        {
            return paciente;
        }
        public void setPaciente(Paciente paciente)
        {
            this.paciente = paciente;
        }

        public Medico GetMedico()
        {
            return medico;
        }
        public void setMedico(Medico medico)
        {
            this.medico = medico;
        }

        public Convenio GetConvenio()
        {
            return convenio;
        }
        public void setConvenio(Convenio convenio)
        {
            this.convenio = convenio;
        }

        //======> Metodos <=======

        public void cadastrar()
        {
            int codPaciente, codMedico, codConvenio;
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Relação de pacientes");
            Console.WriteLine("Código | CPF | Nome");

            for(int i = 0; i < contP; i++)//Falta implementar a classe programa<=================
            {
                Console.WriteLine("     "+i);
                p[i].listarPaciente();
                Console.WriteLine("--");
            }
            Console.WriteLine("Escolha um Paciente: ");
            codPaciente = Convert.ToInt32(Console.ReadLine());
            this.setPaciente(p[codPaciente]);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Relação de Médicos");
            Console.WriteLine("Código | CRM | Nome");
            for(int i = 0; i < contM; i++)//Falta implementar a classe programa<=================
            {
                Console.WriteLine("     "+i);
                m[i].listarMedico();
                Console.WriteLine("--");
            }
            Console.WriteLine("Escolha um Médico: ");
            codMedico = Convert.ToInt32(Console.ReadLine());
            this.setMedico(m[codMedico]);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Relação de Convênios");
            Console.WriteLine("Código | Nome");
            for (int i = 0; i < contC; i++)
            {
                Console.WriteLine("     "+i);
                c[i].imprimirConvenio();
                Console.WriteLine("--");
            }
            Console.WriteLine("Escolha um Convênio: ");
            codConvenio = Convert.ToInt32(Console.ReadLine());
            this.setCodigo(c[codConvenio]);
        }

        public void imprimirPedidoExame()
        {
            Console.WriteLine("Médico: "+this.GetMedico().getNome());
            Console.WriteLine("Convênio: "+this.GetConvenio().getNome());
            Console.WriteLine("Paciente: "+this.GetPaciente().getNome());
        }
    }
}