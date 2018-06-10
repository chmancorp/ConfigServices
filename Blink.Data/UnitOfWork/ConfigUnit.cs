using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blink.Data.DataAcces;

namespace Blink.Data.UnitOfWork
{
    public class ConfigUnit : IConfigUnit
    {
        private ConfigServiceDataBaseContext _dbContext;
        public ConfigUnit(ConfigServiceDataBaseContext dbContext)
        {
            _dbContext = dbContext;
            BlinkConfigRepository = new BlinkConfigRepository(dbContext);

        }
        public IBlinkConfigRepository BlinkConfigRepository
        {
            get; private set;
        }

        public Task Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
