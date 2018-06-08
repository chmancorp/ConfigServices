using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blink.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        Task Complete();
    }
}
