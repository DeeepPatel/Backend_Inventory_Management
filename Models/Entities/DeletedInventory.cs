using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deep_Patel_Backend_Challenge.Models.Entities
{
    public class DeletedInventory
    {
        public Guid Id { get; set; }
        public Inventory Inventory { get; set; }
        public string DeleteComment { get; set; }
    }
}