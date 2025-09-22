using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.model
{
    internal class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
