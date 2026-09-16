using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02
{
    internal class Shipment
    {
        #region Question03 
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;


        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get => trackingCode;
            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }


        public string Description
        {
            get => description;
            set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }


        public double Weight
        {
            get => weight;
            set
            {

                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set
            {

                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }


        public decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5m);
        }


        public Shipment(string trackingCode){

            this.trackingCode = "DEFAULT_CODE";
            this.description = "Unknown";
            this.weight = 1.0;
            this.deliveryFee = 50m;
            this.Destination = default;


            TrackingCode = trackingCode;
        }


        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {

            this.trackingCode = "DEFAULT_CODE";
            this.description = "Unknown";
            this.weight = 1.0;
            this.deliveryFee = 50m;
            this.Destination = destination;


            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }


        public void PrintShipment()
        {
            Console.WriteLine("");
            Console.WriteLine($" Tracking Code : {TrackingCode}");
            Console.WriteLine($" Description   : {Description}");
            Console.WriteLine($" Weight        : {Weight} kg");
            Console.WriteLine($" Delivery Fee  : ${DeliveryFee}");
            Console.WriteLine($" Estimated Cost: ${EstimatedCost}");
            Console.WriteLine($" Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine("");
        }


        #endregion
    }
}
