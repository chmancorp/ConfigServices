using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blink.Data.DataAcces
{
    public interface IBlinkConfigRepository
    {
        Task<int> GetNumIntents(int data);
    }
}
