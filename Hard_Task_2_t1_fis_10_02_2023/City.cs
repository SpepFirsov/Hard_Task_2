using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hard_Task_2_t1_fis_10_02_2023
{
        class City
    {
        public City(string name, double travel_cost, double transit,bool was_there)
        {
            this.name = name;
            this.travel_cost = travel_cost;
            this.transit = transit;
            this.was_there = was_there;
        }

        public string name { get; set; }
        public double travel_cost { get; set; }
        public double transit { get; set; }
        public bool was_there { get; set; }
    }
}
