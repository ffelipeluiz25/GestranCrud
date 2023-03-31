using CrudLuizFelipe.Utils;
namespace CrudLuizFelipe.DataTransferObject
{
    public class FornecedorDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public int Cnpj { get; set; }
        public string CnpjFormatado
        {
            get
            {
                return Cnpj != 15 ? "Cnpj Inválido" : Util.FormataCnpj(Cnpj);
            }
        }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
