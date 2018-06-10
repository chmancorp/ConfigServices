using System;
using System.Collections.Generic;

namespace Blink.Data.DataAcces
{
    public partial class BlockUserDb
    {
        public int BlockUserId { get; set; }
        public int? AcctionId { get; set; }
        public int? IntentNumber { get; set; }
        public int? BlockTime { get; set; }
    }
}
