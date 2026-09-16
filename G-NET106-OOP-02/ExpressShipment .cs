using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02
{
    internal class ExpressShipment : Shipment
    {
        #region Question04

        decimal extraFee;


        public decimal ExtraFee
        {
            get => extraFee;

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override  decimal EstimatedCost
        {
            get => base.EstimatedCost + ExtraFee;
        }


        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,decimal extraFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            ExtraFee = extraFee;

        }

        #endregion
    }
}
