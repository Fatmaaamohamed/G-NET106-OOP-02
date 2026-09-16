using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02
{
    internal class InternationalShipment :Shipment
    {
        #region Question04
        string destinationCountry;


        Decimal customsFee;


        public string DestinationCountry
        {
            get => destinationCountry;


            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }

        }


        public decimal CustomsFee
        {
            get => customsFee;


            set
            {
                if (value>=0)
                {
                    customsFee= value;
                }
            }

        }


        public override decimal EstimatedCost
        {
            get => base.EstimatedCost + CustomsFee;

        }


        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,string destinationCountry , decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }

        #endregion
    }
}
