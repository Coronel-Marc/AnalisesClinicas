namespace Laboratorio.Models
{
    public class Cidade
    {
        private String? nome, ddd;
        private Uf uf = new Uf();

        public String? getDdd()
        {
            return ddd;
        }
        public void setDdd(String ddd)
        {
            this.ddd = ddd;
        }

        public Uf getUf()
        {
            return uf;
        }
        public void setUf(Uf uf)
        {
            this.uf = uf;
        }

        public String? getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        //Metodos


        public void cadastrar()
        {
            Console.WriteLine("Cidade: ");
            this.setNome(Console.ReadLine());

            Console.WriteLine("DDD: ");
            this.setDdd(Console.ReadLine());
        }
        public void imprimirCidade()
        {
            Console.WriteLine("Cidade: "+this.getNome());
            Console.WriteLine("DDD: "+this.getDdd());
            uf.imprimirUf();
        }

        public void listarCidades()
        {
            Console.WriteLine(" | "+this.getUf());
            Console.WriteLine(" | "+this.getNome());
        }
    }
}