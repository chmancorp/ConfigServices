using Blink.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blink.Data.DataAcces
{
    public class BlinkConfigRepository : IBlinkConfigRepository
    {
        public async Task<int> GetNumIntentsAsync(int data)
        {
            /************************
             * Query for the numbers of intents
             * **********************/
            int querynumb = 2;
             /*******************************
              * ****************************/
            ConfigModel modelConfig = new ConfigModel();

            modelConfig.ConfigId = 1;
            modelConfig.IntentsNumber = "1";
            int dataRet = await Task.FromResult(querynumb);
            
            return  dataRet;
        }
    }
}
