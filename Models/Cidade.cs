namespace Laboratorio.Models
{
    public class Cidade
    {
        private String nome, ddd;
        private Uf uf = new Uf();

        public String getDdd()
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

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
    }
}