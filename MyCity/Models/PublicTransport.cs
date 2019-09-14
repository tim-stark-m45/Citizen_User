using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCity.Models
{
    class PublicTransport
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Text { get; set; }
        public string DateTime { get; set; }
        public string Header { get; set; }
    }
}
