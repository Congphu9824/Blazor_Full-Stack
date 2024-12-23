using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Note
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int? ContactId { get; set; }
        public Contact? Contact { get; set; }
    }
}
