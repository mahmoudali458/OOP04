using OOP_2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
   sealed class CompletedShipment : Shipment
    {

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }


        public override decimal EstimatedCost => throw new NotImplementedException();
    }
}
