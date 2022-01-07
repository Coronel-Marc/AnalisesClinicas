using System.Globalization;

namespace Laboratorio.Models
{
    public class Paciente
    {
        private int codigo {get; set;}
        private String? nome {get; set;}
        private String? endereco {get; set;}
        private String? CEP {get; set;}
        private String? telefone {get; set;}
        private String? dataNascimento {get; set;}
        private String? RG {get; set;}
        private String? CPF {get; set;}
        private Cidade cidade = new Cidade();

        //===========>

        //codigo
        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        //nome
        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }


        //endereço
        public String getEndereco()
        {
            return endereco;
        }
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }


        //CEP
        public String getCEP()
        {
            return CEP;
        }
        public void setCEP(String CEP)
        {
            this.CEP = CEP;
        }

        //telefone
        public String getTelefone()
        {
            return telefone;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        //Data de nascimento
        public String getDataNascimento()
        {
            string.Format("{0:d/M/yyyy}", dataNascimento);
            return dataNascimento;
        }
        public void setDataNascimento( String dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        //RG
        public String getRG()
        {
            return RG;
        }
        public void setRG (String RG)
        {
            this.RG = RG;
        }

        //CPF
        public String getCPF()
        {
            return CPF;
        }
        public void setCPF(String CPF)
        {
            this.CPF = CPF;
        }

        //cidade
        public Cidade getCidade()
        {
            return cidade;
        }
        public void setCidade(Cidade cidade)
        {
            this.cidade = cidade;
        }

        //============>

        public void cadastrar()
        {
            Console.WriteLine("Informe os dados do paciente ");
            Console.WriteLine("Nome: ");
            this.setNome(Console.ReadLine());

            Console.WriteLine("Endereço: ");
            this.setEndereco(Console.ReadLine());

            Console.WriteLine("CEP: ");
            this.setCEP(Console.ReadLine());

            Console.WriteLine("telefone: ");
            this.setTelefone(Console.ReadLine());

            Console.WriteLine("Data de Nascimento Ex:[00/00/0000]:  ");
            this.setDataNascimento(Console.ReadLine());

            Console.WriteLine("RG: ");
            this.setRG(Console.ReadLine());

            Console.WriteLine("CPF: ");
            this.setCPF(Console.ReadLine());

            cidade.cadastrar(); //Falta implementar

            

        }

        //==============> Metodo imprimir paciente

        public void imprimirPaciente()
        {
            Console.WriteLine("Paciente: "+this.getNome());
            Console.WriteLine("Endereço: "+this.getCidade());
            Console.WriteLine("CEP: "+this.getCEP());
            Console.WriteLine("Telefone: "+this.getTelefone());
            Console.WriteLine("Data de Nascimento: "+this.getDataNascimento());
            Console.WriteLine("RG: "+this.getRG());
            Console.WriteLine("CPF: "+this.getCPF());
            cidade.imprimirCidade(); //Falta implementar
        }

        //==============> Metodo listar pacientes

        public void listarPacientes()
        {
            Console.WriteLine(" | "+this.getCPF());
            Console.WriteLine(" | "+this.getNome());
        }
    }
}