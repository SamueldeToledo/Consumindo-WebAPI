using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_WebAPI.Entities
{
    public class Slip
    {
        public int id { get; set; }
        public string? advice { get; set; }
    }

    public class AdviceResponse
    {
        public Slip? slip{ get; set; }
    }
}
