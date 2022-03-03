using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
