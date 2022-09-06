using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Assunto { get; set; }
        public double Proposta { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
