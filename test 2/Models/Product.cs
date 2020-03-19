using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_2.Models
{
    public class Product
    { // THIS CLASS TO ONLY GIVE THE PRODUCT ID NAME ETC..
        public int id{ get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string image { get; set; }
    }
}
