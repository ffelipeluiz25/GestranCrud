using CrudLuizFelipe.DataTransferObject;
using CrudLuizFelipe.Services.Interface;
using Microsoft.AspNetCore.Mvc;
namespace CrudLuizFelipe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly ILogger<FornecedorController> _logger;
        private readonly IFornecedorService _serviceFornecedor;

        public FornecedorController(ILogger<FornecedorController> logger, IFornecedorService serviceFornecedor)
        {
            _logger = logger;
            _serviceFornecedor = serviceFornecedor;
        }

        [HttpGet(Name = "GetFornecedores")]
        public IEnumerable<FornecedorDto> Get()
        {
            try
            {
                return _serviceFornecedor.GetFornecedores();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message, new { method = "GetFornecedores" });
                throw ex;
            }

        }

        [HttpGet("GetFornecedoresById")]
        public FornecedorDto GetFornecedoresById([FromQuery] int id)
        {
            try
            {
                return _serviceFornecedor.GetFornecedoresById(id);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message, new { method = "GetFornecedoresById" });
                throw ex;
            }
        }

        [HttpGet("GetFornecedoresByParams")]
        public IEnumerable<FornecedorDto> GetFornecedoresByParams([FromQuery] FornecedoresFiltroDto filter)
        {
            try
            {
                return _serviceFornecedor.GetFornecedoresByParams(filter);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message, new { method = "GetFornecedoresByParams" });
                throw ex;
            }
        }

        [HttpPost(Name = "CreateFornecedor")]
        public bool Save([FromBody] FornecedorDto fornecedor)
        {
            try
            {
                return _serviceFornecedor.Save(fornecedor);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message, new { method = "GetFornecedores" });
                throw ex;
            }

        }

    }
}