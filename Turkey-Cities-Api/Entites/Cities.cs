using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turkey_Cities_Api.Entites
{
    public class Cities
    {
        public int Id { get; set; }
        public string City { get; set; }

        // Int32 Max :  2147483647
        public int Population { get; set; }
        public string Region { get; set; }
    }
}
