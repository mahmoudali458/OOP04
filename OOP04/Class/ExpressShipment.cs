using OOP04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
    class ExpressShipment : Shipment , ITrackable,IInsurable
    {
        public ExpressShipment()
        {
            Console.WriteLine("Shipment added successfully !");
        }
        decimal extraFee;
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if(value<=0)
                    Console.WriteLine("invalid ");
                else { extraFee=value; }
            }
        }
        
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAdd destination,decimal extraFee) : 
            base(trackingCode,description,weight,deliveryFee,destination)
        {
            ExtraFee = extraFee; 
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
          

        }
        public override string ShipmentTypeName
        {
            get
            {
                return "Exbress Shipment ";
            }
        }
        public override void PrintShipment()
        {

            Console.WriteLine($"---------shipment data----------");
            Console.WriteLine($"Tracking code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight}");
            Console.WriteLine($"Delivery fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Extra fee      : {ExtraFee} EGP");
            Console.WriteLine($"Estimated cost : {EstimatedCost}  EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Out for Delivery.";

        public decimal CalculateInsurance() => EstimatedCost * 0.08m;
    }
}
