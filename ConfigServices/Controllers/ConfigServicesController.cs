using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blink.Data.DataAcces;
using Blink.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blink.ConfigServices.Controllers
{
    [Produces("application/json")]
    [Route("api/ConfigServices")]
    public class ConfigServicesController : Controller
    {
        private readonly IBlinkConfigRepository _blinkConfigRepository;
       
        public ConfigServicesController(IBlinkConfigRepository blinkConfigRepository)
        {
            _blinkConfigRepository = blinkConfigRepository;
        }
        [HttpGet]
        public async Task<int> GetIntNumber(int catalogconfigId)
        {
            catalogconfigId = 1;
            var numData = await _blinkConfigRepository.GetNumIntentsAsync(catalogconfigId);
            return numData;
        }
    }
}