

namespace Blink.ConfigServices.Controllers
{
    using System.Threading.Tasks;
    using Blink.Data.DataAcces;
    using Microsoft.AspNetCore.Mvc;
    [Produces("application/json")]
    [Route("api/ConfigServices")]
    public class ConfigServicesController : Controller
    {
        private readonly IBlinkConfigRepository _blinkConfigRepository;
       
        public ConfigServicesController(IBlinkConfigRepository blinkConfigRepository)
        {
            _blinkConfigRepository = blinkConfigRepository;
        }
        [Route("api/ConifgServices/GetIntNumber")]
        [HttpGet]
        public async Task<int> GetIntNumber(int catalogconfigId)
        {
            catalogconfigId = 1;
            var numData = await _blinkConfigRepository.GetNumIntentsAsync(catalogconfigId);
            return numData;
        }

        [HttpGet]
        public  Task GetBlockUser()
        {
            return null;
        }

        [HttpGet]
        public async Task GetCodeAuth()
        {

        }

        [HttpGet]
        public async Task GetSystemMessage()
        {

        }

        [HttpGet]
        public async Task GetFrequencyRequest()
        {

        }

   
    }
}