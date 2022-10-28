using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_eval.Models
{
    public class Inventory
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }
    }
}