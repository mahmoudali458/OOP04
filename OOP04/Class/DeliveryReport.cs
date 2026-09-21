using OOP04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Class
{
   public static class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}
