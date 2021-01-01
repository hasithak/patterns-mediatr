using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Seat { get; set; }
        public string UserId { get; set; }
    }
}
