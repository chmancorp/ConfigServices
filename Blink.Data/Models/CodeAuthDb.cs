using System;
using System.Collections.Generic;

namespace Blink.Data.DataAcces
{
    public partial class CodeAuthDb
    {
        public int CodeAuthId { get; set; }
        public int? Validity { get; set; }
        public int? ActionId { get; set; }
        public int? Period { get; set; }
        public int? CodeTotalPeriod { get; set; }
    }
}
