using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
    public class DeliveryAdd
    {
        public DeliveryAdd()
        {
            
        }
        public string city;
        public string street;
        public int BuildNum;

        public DeliveryAdd(string city/*, string street, int BuildNum*/)
        {
            this.city = city;
            //this.street = street;
            //this.BuildNum = BuildNum;

        }
        public string GetAdd()
        {
            return $"{city} ";

        }
    }
}
