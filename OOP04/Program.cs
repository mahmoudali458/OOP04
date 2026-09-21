using OOP_2.Class;
using OOP03.Class;
using OOP04.Class;
using OOP04.Interface;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DeliveryCenter center = new DeliveryCenter();
            Console.WriteLine("enter center name ");
            center.CenterName = Console.ReadLine();
          
            StandardShipment stand = new StandardShipment();
            DeliveryAdd add1 = new DeliveryAdd();
            ExpressShipment express = new ExpressShipment();
            DeliveryAdd add2 = new DeliveryAdd();
            InternationalShipment international = new InternationalShipment();
            DeliveryAdd add3 = new DeliveryAdd();
            Console.WriteLine($"center name : {center.CenterName}");
            Console.WriteLine("===============================");
            decimal Weight;
            decimal UpWeight;
            decimal fee;
            decimal extraFee;
            decimal customFee;
            int buildnum;

            Console.WriteLine("Enter standard shipment Data : ");
            Console.WriteLine();
            Console.WriteLine($"Tracking code : ");
            stand.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            stand.Description = Console.ReadLine();
            Console.WriteLine("weight : ");
            decimal.TryParse(Console.ReadLine(), out Weight);
            stand.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            Decimal.TryParse(Console.ReadLine(), out fee);
            stand.ApplyFee(fee);
            Console.WriteLine($"estimated cost : {stand.EstimatedCost}");
            center.AddShipment(stand);

            Console.WriteLine("///////////////////////////////////////////");

            Console.WriteLine("Enter Express shipment Data ; ");
            Console.WriteLine();
            Console.WriteLine("Tracking code : ");
            express.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            express.Description = Console.ReadLine();
            Console.WriteLine("weight : ");
            decimal.TryParse(Console.ReadLine(), out Weight);
            express.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            Decimal.TryParse(Console.ReadLine(), out fee);
            express.ApplyFee(fee);
            Console.WriteLine("enter extrafee : ");
            Decimal.TryParse(Console.ReadLine(), out extraFee);
            express.ExtraFee = extraFee;
            Console.WriteLine($"estimated cost : {express.EstimatedCost}");
            center.AddShipment(express);

            Console.WriteLine("//////////////////////////////////////////");

            Console.WriteLine("Enter international shipment Data ; ");
            Console.WriteLine();
            Console.WriteLine($"Tracking code : ");
            international.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            international.Description = Console.ReadLine();
            Console.WriteLine("destination country  : ");
            international.Country = Console.ReadLine();
            Console.WriteLine("weight : ");
            decimal.TryParse(Console.ReadLine(), out Weight);
            international.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            Decimal.TryParse(Console.ReadLine(), out fee);
            international.ApplyFee(fee);
            Console.WriteLine("enter custom fee : ");
            Decimal.TryParse(Console.ReadLine(), out customFee);
            international.CustomFee = customFee;
            Console.WriteLine($"estimated cost : {international.EstimatedCost}");
            center.AddShipment(international);

            Console.WriteLine("//////////////////////////////////////////");
            center.PrintAllShipment();
            #region task3
            //DeliveryHelper.PrintShipmentDetails(stand);
            //DeliveryHelper.PrintShipmentDetails(express);
            //DeliveryHelper.PrintShipmentDetails(international);

            //Console.WriteLine($"Original Weight : {stand.Weight} KG");
            //stand.WeightUpdate(5);               
            //Console.WriteLine($"Updated Weight : {stand.Weight} KG");
            //stand.WeightUpdate(5, 0.5m);       
            //Console.WriteLine($"Updated Weight After Packing : {stand.Weight} KG");
            //Console.WriteLine();

            //Shipment[] mixedShipments = { stand, express, international };
            //foreach (Shipment s in mixedShipments)
            //{
            //    Console.WriteLine($"{s.ShipmentTypeName}...");
            //    s.PrintShipment(); 
            //    Console.WriteLine();
            //}
            #endregion

            //DeliveryReport.PrintShipment(stand);
            //DeliveryReport.PrintShipment(express);
            //DeliveryReport.PrintShipment(international);

            //printing tracking status and insurance
            Console.WriteLine("Shipments tracking status : ");
            center.PrintTrackingStatuses();
            Console.WriteLine();
            Console.WriteLine($"price after insurance for {stand.ShipmentTypeName} : ");
            DeliveryReport.PrintInsurance(stand);
            Console.WriteLine();
            Console.WriteLine($"price after insurance for {express.ShipmentTypeName} : ");
            DeliveryReport.PrintInsurance(express);
            Console.WriteLine();
            Console.WriteLine($"price after insurance for {international.ShipmentTypeName} : ");
            DeliveryReport.PrintInsurance(international);
            // storing


            ITrackable[] trackabels = { stand, express, international };
            Console.WriteLine("traclabels : ");
            foreach(ITrackable t in trackabels)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }
            IInsurable [] insurables = { stand, express, international };
            Console.WriteLine("insurables : ");
            foreach(IInsurable I in insurables)
            {
                Console.WriteLine(I.CalculateInsurance());
            }
        }
    }
}
