using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
  public abstract class Shipment
    {
        public Shipment()
        {
            
        }

        string trackingCode;
        string description;
        decimal weight;
        decimal weightUp;
        decimal deliveryFee;
        decimal NewFee;
        //////////////
        #region properites
        public string TrackingCode
        {

            get { return trackingCode; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tracking code cannot be empty.");
                }
                trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            //read onlyyyy
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal WeightUp
        {
            get { return weightUp; }
            set
            {
                if (value > 0)
                    weightUp = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAdd Destination { get; set; }


         public abstract decimal EstimatedCost { get; }

        #endregion

        #region constructor

                public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAdd destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public abstract void PrintShipment();
        //{
        //    Console.WriteLine($"---------shipment data----------");
        //    Console.WriteLine($"Tracking code : {TrackingCode}");
        //    Console.WriteLine($"Description : {Description}");
        //    Console.WriteLine($"Weight : {Weight}");
        //    Console.WriteLine($"Delivery fee : {DeliveryFee}");
        //  //  Console.WriteLine($"Destination : {Destination.GetAdd()}");
        //    Console.WriteLine($"Estimated cost : {EstimatedCost}");
        //}
        public void UpdateDeliveryFee(decimal NewFee)
        {
            if (NewFee > 0)
                this.NewFee = NewFee;

        }
        public void ApplyFee(decimal fee)
        {
            DeliveryFee = fee;
        }

        public void WeightUpdate(decimal UpdateWeight)
        {
            Weight = UpdateWeight;
        }

        public void WeightUpdate(decimal UpdateWeight,decimal extraPack)
        {
            Weight = UpdateWeight + extraPack;
        }

        public virtual string ShipmentTypeName
        {
            get
            {
                return "Standard Shipment";
            }
        }
      


        #endregion


    }
}
