using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02
{
    internal class DeliveryCenter
    {
        #region Question05

        Shipment[] shipments;

        public string CenterName { get; set; }


        public DeliveryCenter( string centerName = "Main Delivery Center " )
        {

            CenterName = CenterName;

            shipments = new Shipment[20];
        }


        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                {
                    return null;
                }
                return shipments[index];
            }
            set
            {
                if (shipments != null && index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                foreach (var s in shipments)
                {
                    if (s != null && s.TrackingCode == trackingCode)
                    {
                        return s;
                    }
                }

                return null;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new Shipment[20];
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null || string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false; // Center is full
        }


        public bool RemoveShipment(string trackingCode)
        {
            if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null; // Clear position
                    return true;
                }
            }

            return false; // Tracking code not found
        }


        public void PrintAllShipments()
        {
            Console.WriteLine($"=== Shipments at {CenterName} ===");
            bool hasShipments = false;

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && !string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    hasShipments = true;
                    Console.WriteLine($"[{i + 1}] Code: {shipments[i].TrackingCode} | Desc: {shipments[i].Description} | Weight: {shipments[i].Weight}kg | Est. Cost: {shipments[i].EstimatedCost:C}");
                }
            }

            if (!hasShipments)
            {
                Console.WriteLine("No shipments stored in this center.");
            }
        }
        #endregion
    }
}
