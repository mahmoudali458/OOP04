using OOP04.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
    class StandardShipment : Shipment ,ITrackable,IInsurable
    {
        public StandardShipment()
        {
            Console.WriteLine("Shipment added successfully !");
        }
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAdd destination) : 
            base(trackingCode, description, weight, deliveryFee, destination)
        {
            
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + Weight * 5;
            }
        }
        public override void PrintShipment()
        {

            Console.WriteLine($"---------shipment data----------");
            Console.WriteLine($"Tracking code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight}");
            Console.WriteLine($"Delivery fee   : {DeliveryFee}  EGP");
            Console.WriteLine($"Estimated cost : {EstimatedCost}  EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Ready.";

        public decimal CalculateInsurance() => EstimatedCost * 0.05m;
    }
}
