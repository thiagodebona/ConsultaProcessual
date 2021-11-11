using Microsoft.Extensions.Logging;

namespace ConsultaProcessual.Service.Services
{
    public class BaseService
    {
        private readonly ILogger _logger;
        public BaseService(ILogger logger)
        {
            _logger = logger;
        }
    }
}
