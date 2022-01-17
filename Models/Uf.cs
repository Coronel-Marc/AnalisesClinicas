namespace Laboratorio
{
    public class Uf
    {
        private String? nome;
        private String? sigla;

        public String? getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String? getSigla()
        {
            return sigla;
        }
        public void setSigla(String sigla)
        {
            this.sigla = sigla;
        }

        //===========================> Metodos <===========================
        public void cadastrar()
        {
            Console.WriteLine("Estado: ");
            this.setNome(Console.ReadLine());

            Console.WriteLine("Sigla: ");
            this.setSigla(Console.ReadLine());
        }
        public void imprimirUf()
        {
            Console.WriteLine("Estado: "+this.getNome());
            Console.WriteLine("Sigla: "+this.getSigla());
        }
    }
}