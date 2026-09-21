using OOP04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
    class InternationalShipment : Shipment ,ITrackable,IInsurable
    {
        public InternationalShipment()
        {
            Console.WriteLine("Shipment added successfully !");
        }
        decimal customFee;
        string country;
        public string Country { get; set; }
        public decimal CustomFee
        {
            get { return customFee; }
            set
            {
                if(value<=0)
                    Console.WriteLine("invalid");
                else { customFee=value; }
            }

        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAdd destination, decimal customFee) : 
            base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomFee = customFee;
        }


        public override decimal EstimatedCost
        {
            get { 

                return DeliveryFee + (Weight *5) + CustomFee;

                }
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"---------shipment data----------");
            Console.WriteLine($"Tracking code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight}");
            Console.WriteLine($"Delivery fee   : {DeliveryFee}  EGP");
            Console.WriteLine($"destination    : {Country}");
            Console.WriteLine($"Estimated cost : {EstimatedCost}  EGP");
            //  Console.WriteLine($"Destination : {Destination.GetAdd()}");
        }
      
        public override string ShipmentTypeName
        {
            get
            {
                return "International Shipment ";
            }
        }
        public string GetTrackingStatus() => $"Shipment {TrackingCode} has been Delivered.";

        public decimal CalculateInsurance() => EstimatedCost * 0.12m;

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs report for {TrackingCode}: destination {Country}, " +
                               $"customs fee {CustomFee} EGP.");
        }

    }
}
