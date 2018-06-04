

namespace Blink.Data.DataAcces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    public class BlinkDataContext: DbContext
    {
        public BlinkDataContext(DbContextOptions<BlinkDataContext> options) : base(options) { }

    }
}
