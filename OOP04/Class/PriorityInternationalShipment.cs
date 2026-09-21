using OOP_2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Class
{
    class PriorityInternationalShipment : InternationalShipment
    {
        
            public PriorityInternationalShipment(string trackingCode, string description, decimal weight,  decimal deliveryFee, DeliveryAdd destination,
                                                  string destinationCountry, decimal customsFee)
                : base(trackingCode, description, weight, deliveryFee, destination, customsFee)
            {
            }

            public sealed override void GenerateCustomsReport()
            {
                Console.WriteLine($"[PRIORITY] Customs report for {TrackingCode}: destination {Country}, " +
                                   $"customs fee {CustomFee} EGP. Priority processing applied.");
            }
        }
    }

