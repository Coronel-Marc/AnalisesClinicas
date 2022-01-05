namespace Laboratorio.Models
{
    public class Paciente
    {
        private int codigo {get; set;}
        private String? nome {get; set;}
        private String? endereco {get; set;}
        private String? CEP {get; set;}
        private String? telefone {get; set;}
        private DateTime dataNascimento {get; set;}
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
        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }
        public void setDataNascimento( DateTime dataNascimento)
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
            Console.Write("Nome: ");
            this.setNome(Console.ReadLine());

            Console.Write("Endereço: ");
            this.setEndereco(Console.ReadLine());

            Console.Write("CEP: ");
            this.setCEP(Console.ReadLine());

            Console.Write("telefone: ");
            this.setTelefone(Console.ReadLine());

            Console.Write("Data de Nascimento Ex:[00/00/0000]:  ");
            this.setDataNascimento(Console.ReadLine());
        }
    }
}