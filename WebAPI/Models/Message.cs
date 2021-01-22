using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MassageDesction { get; set; }
        public string  UserId { get; set; }
        public string FromId { get; set; }
        public DateTime Time { get; set; }
    }
}
