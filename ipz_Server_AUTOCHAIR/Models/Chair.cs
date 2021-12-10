using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ipz_Server_AUTOCHAIR
{
    public class Chair
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Prise { get; set; }
        public byte[] Image { get; set; }

    }
}
