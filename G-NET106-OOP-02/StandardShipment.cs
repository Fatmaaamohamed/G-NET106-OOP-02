using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02
{
    internal class StandardShipment : Shipment
    {
        #region Question04
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        } 

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) :
            base (trackingCode, description, weight,deliveryFee,destination){


        }


        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
        }

        #endregion
    }
}
