namespace Laboratorio
{
    public class Exame
    {
        private int codigo;
        private String descricao;
        private double valor;
        private String procedimentos;
        private GrupoExame grupoExame = new GrupoExame();

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

        public double getValor()
        {
            return valor;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public String getProcedimentos()
        {
            return procedimentos;
        }
        public void setProcedimentos(String procedimentos)
        {
            this.procedimentos = procedimentos;
        }

        public GrupoExame getGrupoExame()
        {
            return grupoExame;
        }
        public void setGrupoExame(GrupoExame grupoExame)
        {
            this.grupoExame = grupoExame;
        }

        //======> Metodos <=======

        public void cadastrar()
        {
            int codGrupoExame;
            Console.WriteLine("------------------------");
            Console.WriteLine("Relação dos Grupos");
            Console.WriteLine("Código | Grupos");

            for (int i = 0; i < contGe; i++)
            {
                Console.WriteLine("     "+i);
                ge[i].listarGrupoExame();
                Console.WriteLine();
            }

            Console.WriteLine("Vincule a um grupo");
            codGrupoExame = Convert.ToInt32(Console.ReadLine());
            this.setGrupoExame(ge[codGrupoExame]);
            Console.ReadLine();

            Console.WriteLine("Código: ");
            this.setCodigo(Console.Read()); //Verificar

            Console.WriteLine("Exame");
            this.setDescricao(Console.ReadLine());

            Console.WriteLine("Valor");
            this.setValor(Console.Read());

            Console.WriteLine("Procedimentos");
            this.setProcedimentos(Console.ReadLine());
        }

        public void imprimirExame()
        {
            Console.WriteLine("Código.........: "+this.getCodigo());
            Console.WriteLine("Exame..........: "+this.getDescricao());
            Console.WriteLine("Grupo do Exame.: "+this.getGrupoExame().getDescricao());
            Console.WriteLine("Valor..........: "+this.getValor());
            Console.WriteLine("Procedimentos..: "+this.getProcedimentos());
            Console.WriteLine("-------------------");
        }
    }
}