using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Mgt_Gurmukh.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public List<StockMaintain> StockMaintains { get; set; }
    }
}
