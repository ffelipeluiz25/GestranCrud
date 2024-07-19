namespace CrudLuizFelipe.Model
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public int Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
