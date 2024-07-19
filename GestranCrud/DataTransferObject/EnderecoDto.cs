namespace CrudLuizFelipe.DataTransferObject
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

    }
}
