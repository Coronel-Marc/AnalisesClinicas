namespace Laboratorio.Models
{
    public class ExamePedidoExame
    {
        private DateTime dataRealizacaoExame;
        private DateTime dataPronto;
        private Exame examePedido = new Exame();
        private DateTime horaRealizacaoExame;
        private DateTime horaPronto;
        private String resultado;


        public Exame getExamePedido()
        {
            return examePedido;
        }
        public void setExamePedido(Exame examePedido)
        {
            this.examePedido = examePedido;
        }

        public DateTime getDataRealizacaoExame()
        {
            return dataRealizacaoExame;
        }
        public void setDataRealizacaoExame(DateTime dataRealizacaoExame)
        {
            this.dataRealizacaoExame = dataRealizacaoExame;
        }

        public DateTime getDataPronto()
        {
            return dataPronto;
        }
        public void setDataPronto(DateTime dataPronto)
        {
            this.dataPronto = dataPronto;
        }

        public DateTime getHoraRealizacaoExame() {
            return horaRealizacaoExame;
        }
        public void setHoraRealizacaoExame(DateTime horaRealizacaoExame) {
            this.horaRealizacaoExame = horaRealizacaoExame;
        }

        public DateTime getHoraPronto() {
            return horaPronto;
        }
        public void setHoraPronto(DateTime horaPronto) {
            this.horaPronto = horaPronto;
        }

        public String getResultado() {
            return resultado;
        }

        public void setResultado(String resultado) {
            this.resultado = resultado;
        }

        public void cadastrar(){
            int codE;

            Console.WriteLine("-------------------");
            Console.WriteLine("Relação de Exames");
            Console.WriteLine("Cód | Descrição | Valor");
            for (int i = 0; i < contEx; i++)
            {
                Console.Write("     "+i);
                ex[i].listarExame();
                    Console.WriteLine();
            }

            Console.WriteLine("Escolha um Exame: ");
            codE = Console.Read();
            this.setExamePedido(ex[codE]);

            Console.WriteLine("Data Realização Exame Ex: [02/02/1982]: ");
            String dataRealizarExame = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(dataRealizarExame);
            setDataRealizacaoExame(dt1);


            Console.WriteLine("Data Exame Pronto Ex: [02/02/1982]: ");
            String dataRetirarExame = Console.ReadLine();

            DateTime dt2 = Convert.ToDateTime(dataRetirarExame);
            setDataPronto(dt2);


            Console.WriteLine("Hora Realização Exame Ex: [10:12]:  ");
            String horaRealizarExame = Console.ReadLine();
            DateTime dth1 = Convert.ToDateTime(String.Format("{0: HH:MM:ss}", DateTime.Parse(horaRealizarExame)));

            this.setHoraRealizacaoExame(dth1);


            Console.WriteLine("Hora exame pronto: ");
            String horaRetirarExame = Console.ReadLine();
            DateTime dth2 = Convert.ToDateTime(String.Format("{0: HH:MM:ss}", DateTime.Parse(horaRealizarExame)));

            this.setHoraPronto(dth2);
        }

        public void imprimir()
        {
            Console.WriteLine("Data do Exame: "+getDataRealizacaoExame().ToString());
            Console.WriteLine("Horário do Exame: "+getHoraRealizacaoExame().ToString());
            Console.WriteLine("Data para retirar o Exame: "+getDataPronto().ToString());
            Console.WriteLine("Horário para retirar o exame: "+getHoraPronto().ToString());
        }
    }


}