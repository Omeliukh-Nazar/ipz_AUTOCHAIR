using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ipz_Server_AUTOCHAIR.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Prise { get; set; }
        public int Count { get; set; }
        public int UserId { get; set; }
        public int ChairId { get; set; }

        public User User { get; set; }
        public Chair Chair { get; set; }

    }
}
