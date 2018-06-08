using Blink.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blink.Data.UnitOfWork
{
    public interface IConfigUnit: IUnitOfWork
    {
        IBlinkConfigRepository BlinkConfigRepository { get; }
    }
}
