using Blink.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blink.Data.DataAcces
{
    public interface IBlinkConfigRepository
    {
        Task<int> GetNumIntentsAsync(int data);
        Task<BlockUserDb> GetBlockUser(int BlockUserId);
        Task<CodeAuthDb> GetCodeAuth(int CodeAuthId);
        Task<FrequencyRequestDB> GetFrequencyRequest(int FrequencyId);
        Task<MessageSystemDb> GetMessageSystemDb(int MessageSystemId);
    }
}
