using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyCity.Models
{
    class Infrastructure
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Text { get; set; }
        public string DateTime { get; set; }
        public string Header { get; set; }
    }
}
