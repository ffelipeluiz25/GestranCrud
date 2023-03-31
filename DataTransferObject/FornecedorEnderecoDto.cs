namespace CrudLuizFelipe.DataTransferObject
{
    public class FornecedorEnderecoDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public int FornecedorId { get; set; }
        public int EnderecoId { get; set; }
    }
}
