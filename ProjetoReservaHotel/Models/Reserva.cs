namespace ProjetoReservaHotel.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string TipoSuite { get; set; }
        public int QuantidadeDePessoas{ get; set; }
        public int QuantidadeDeDias{ get; set; }
        public DateTime Data { get; set; }
        public string Pagamento { get; set; }
    }
}
