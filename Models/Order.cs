﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipz_AUTOCHAIR.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Prise { get; set; }
        public int Count { get; set; }
        public int UserId { get; set; }
        public int ChairId { get; set; }

        public User User { get; set; }
        public Chair Chair { get; set; }

    }
}
