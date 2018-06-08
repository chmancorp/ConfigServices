using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blink.Data.DataAcces;

namespace Blink.Data.UnitOfWork
{
    public class ConfigUnit : IConfigUnit
    {

        public IBlinkConfigRepository BlinkConfigRepository => throw new NotImplementedException();

        public Task Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
