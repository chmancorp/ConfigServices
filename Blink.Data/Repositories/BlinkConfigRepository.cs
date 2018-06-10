
namespace Blink.Data.DataAcces
{
    using System.Linq;
    using System.Threading.Tasks;

    public class BlinkConfigRepository : IBlinkConfigRepository
    {
        private readonly ConfigServiceDataBaseContext _dbContext;

        public BlinkConfigRepository(ConfigServiceDataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Get Intent number
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<int> GetNumIntentsAsync(int data)
        {
            /************************
             * Query for the numbers of intents
             * **********************/
            var numquery = _dbContext.ValidationDb.Where(wr => data == wr.ValidaConfigId).Select(s => s.Value).FirstOrDefault();
            int querynumb = (int)numquery;
            /*******************************
             * ****************************/
            int dataRet = await Task.FromResult(querynumb);
            return dataRet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BlockUserId"></param>
        /// <returns></returns>
        public async Task<BlockUserDb> GetBlockUser(int BlockUserId)
        {
            var blockUser = _dbContext.BlockUserDb.Where(wr => wr.BlockUserId == BlockUserId).FirstOrDefault();

            return await Task.FromResult(blockUser);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CodeAuthId"></param>
        /// <returns></returns>
        public async Task<CodeAuthDb> GetCodeAuth(int CodeAuthId)
        {
            var codeAuth = _dbContext.CodeAuthDb.Where(wr => wr.CodeAuthId == CodeAuthId).FirstOrDefault();

            return await Task.FromResult(codeAuth);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FrequencyId"></param>
        /// <returns></returns>
        public async Task<FrequencyRequestDB> GetFrequencyRequest(int FrequencyId)
        {
            var frequency = _dbContext.FrequencyRequestDB.Where(wr => wr.FrequencyId == FrequencyId).FirstOrDefault();

            return await Task.FromResult(frequency);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageSystemId"></param>
        /// <returns></returns>
        public async Task<MessageSystemDb> GetMessageSystemDb(int MessageSystemId)
        {
            var message = _dbContext.MessageSystemDb.Where(wr => wr.MessageSystemId == MessageSystemId).FirstOrDefault();

            return await Task.FromResult(message);
        }
    }
}
