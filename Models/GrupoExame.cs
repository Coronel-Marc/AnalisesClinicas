namespace Laboratorio.Models
{
    public class GrupoExame
    {
        private int codigo;
        private String descricao;

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public String getDescricao()
        {
            return descricao;
        }
        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        //======> Metodos <=======

        public void cadastrar()
        {
            Console.WriteLine("Código do Grupo: ");
            this.setCodigo(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Grupo do Exame: ");
            this.setDescricao(Console.ReadLine());
        }

        public void imprimirGrupoExame()
        {
            Console.WriteLine("Código: "+this.getCodigo());
            Console.WriteLine("Grupo do Exame"+this.getDescricao());
            Console.WriteLine("------------------------");
        }

        public void listarGrupoExame()
        {
            Console.WriteLine(" | "+this.getDescricao());
        }
    }
}