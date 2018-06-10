

namespace Blink.ConfigServices.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Blink.Data.DataAcces;
    using Blink.Data.UnitOfWork;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/ConfigServices")]
    public class ConfigServicesController : Controller
    {
        private readonly IBlinkConfigRepository _blinkConfigRepository;
        private readonly IConfigUnit _configUnit;
        private string badRequest = "Error al consultar informacion";
       
        public ConfigServicesController(IBlinkConfigRepository blinkConfigRepository, IConfigUnit configUnit)
        {
            _blinkConfigRepository = blinkConfigRepository;
            _configUnit = configUnit;
        }
        [Route("GetIntNumber")]
        [HttpGet]
        public async Task<int> GetIntNumber(int catalogconfigId)
        {
            var numData = await _blinkConfigRepository.GetNumIntentsAsync(catalogconfigId);
            return numData;
        }
        [Route("GetBlockUser")]
        [HttpGet]
        public async Task<IActionResult> GetBlockUser(int blockUserId)
        {
            try
            {
                var blockUSerData = await _configUnit.BlinkConfigRepository.GetBlockUser(blockUserId);

                return Ok(blockUSerData);
            }
            catch(Exception ex)
            {
                return BadRequest(badRequest);
            }
            
        }

        [Route("GetCodeAuth")]
        [HttpGet]
        public async Task<IActionResult> GetCodeAuth(int codeAuth)
        {
            try
            {
                var codeAuthData = await _configUnit.BlinkConfigRepository.GetCodeAuth(codeAuth);

                return Ok(codeAuthData);
            }
            catch (Exception ex)
            {
                return BadRequest(badRequest);
            }
        }

        [Route("GetSystemMessage")]
        [HttpGet]
        public async Task<IActionResult> GetSystemMessage(int messageId)
        {
            try
            {
                var messageData = await _configUnit.BlinkConfigRepository.GetMessageSystemDb(messageId);

                return Ok(messageData);
            }
            catch (Exception ex)
            {
                return BadRequest(badRequest);
            }
        }

        [Route("GetFrequencyRequest")]
        [HttpGet]
        public async Task<IActionResult> GetFrequencyRequest(int frequencyId)
        {
            try
            {
                var frequencyData = await _configUnit.BlinkConfigRepository.GetFrequencyRequest(frequencyId);

                return Ok(frequencyData);
            }
            catch (Exception ex)
            {
                return BadRequest(badRequest);
            }
        }

   
    }
}