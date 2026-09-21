using OOP04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Class
{
    class DeliveryCenter
    {
        string centerName;
        public string CenterName { get; set; }
        private Shipment[] shipments = new Shipment[20];

        public DeliveryCenter()
        {
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 10)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < 10)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 10; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("Shipment was successfully added");
                    return true;

                }

            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for(int i=0; i<20 ;i++)
            {
                if (shipments[i].TrackingCode!=null && shipments[i].TrackingCode==trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
             
            }
            return false;
        }

        public void PrintAllShipment()
        {
            for(int i=0; i<20;i++)
            {
                if (shipments[i]!= null)
                { shipments[i].PrintShipment(); }
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (var shipment in shipments)
            {
                if (shipment is ITrackable T)
                {
                    Console.WriteLine(T.GetTrackingStatus());
                }
            }
        }

    }
}
