/// InvoiceItem.cs
/// Ann-Marie Bergström ai2436
/// 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment6
{
    public class InvoiceItem
    {
        public int Item { get; set; }

        public string Desc { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Tax { get; set; }
        
        public decimal TotalTax { get; set; }

        public decimal Total { get; set; }

    }
}
