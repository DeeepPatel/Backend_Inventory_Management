using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deep_Patel_Backend_Challenge.Models.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }        

    }
}