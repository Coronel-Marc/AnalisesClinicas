namespace Laboratorio.Models
{
    public class Medico
    {
        private int CRM;
        private String? nome;

        public int getCRM()
        {
            return CRM;
        }
        public void setCRM(int CRM)
        {
            this.CRM = CRM;
        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        //======> Metodos <=======

        public void cadastrar()
        {
            Console.WriteLine("Nome: ");
            this.setNome(Console.ReadLine());

            Console.WriteLine("CRM: ");
            this.setCRM(Convert.ToInt32(Console.ReadLine()));
        }

        public void imprimirMedico()
        {
            Console.WriteLine("Médico: "+this.getNome());
            Console.WriteLine("CRM: "+this.getCRM());
        }
    }
}