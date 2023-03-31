namespace CrudLuizFelipe.Model
{
    public class FornecedorEndereco
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int FornecedorId { get; set; }
        public int EnderecoId { get; set; }
    }
}
