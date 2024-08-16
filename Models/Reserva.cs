using System.Runtime.InteropServices;


namespace DesafioProjetoHospedagem.Models

{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido || NO TODO
            // *IMPLEMENTE AQUI*
            int CapacidadeDisponivel = Suite.Capacidade;
            int CapacidadeSolicitada = hospedes.Count;
            int resultado = CapacidadeDisponivel - CapacidadeSolicitada;
            

            if (resultado > 0)
            {              
                // Hospedes.Add(hospedes); <<<<<<<<------------não fiz esta adição, não deveria-----------<<<<<<<<<<<<             
                 Hospedes = hospedes;                 
                             
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido || NO TODO
                throw new Exception("Capacidade disponibilizada neste hotel é inferior a capacidade informada de hospedes.");
            }
        }
        

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
       
        {
            int quantidadeHospedes = Hospedes.Count;
            
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes) || NO TODO
            // *IMPLEMENTE AQUI*
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária || NO TODO
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal valorComDesconto = valor * 0.90m;
            
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*           
           
            if (DiasReservados >= 10)
             {
               valor = valorComDesconto;
             }
             return valor;
        }
    }
}