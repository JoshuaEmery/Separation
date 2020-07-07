using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class BarCodeNumbers
    {
        public int BarcodeId { get; set; }
        public int? ClientId { get; set; }
        public int? ReportId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Reports Report { get; set; }
    }
}
