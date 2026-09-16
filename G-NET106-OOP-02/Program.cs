namespace G_NET106_OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /* A) Classes are reference types (allocated on the heap); structs are value types (allocated on the stack),
             Classes pass references—modifications affect the shared instance. Structs pass values—modifications affect only the isolated copy,
             We use Structs when there are lightweight data and for complex ones we use Classes.


              B) Classes are better for large applications because they allow different components to share and edit a single 
              piece of data in real time without making wasteful duplicate copies. They also support inheritance, 
              which lets developers reuse and organize code cleanly as the project grows.
             
             */

            #endregion


            #region Question02

            /* A) Shipment

               B) ExpressShipment

               C) TrackingCode property

               D) Instead of typing the same code in multiple places, you write it once in the parent class. If you ever need to fix or update it,
                  you only change it in one spot instead of fixing it everywhere.

             */

            #endregion


            #region Question06

            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(centerName);
            DeliveryAddress address = new DeliveryAddress("Cairo", "Tahrir", 10);

         
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3m, 80m, address);
            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, address, 30m);
            InternationalShipment international = new InternationalShipment("SH003", "Television", 8m, 120m, address, "Germany", 100m);

            Console.WriteLine();

          
            if (center.AddShipment(standard)) Console.WriteLine("Shipment Added Successfully.");
            if (center.AddShipment(express)) Console.WriteLine("Shipment Added Successfully.");
            if (center.AddShipment(international)) Console.WriteLine("Shipment Added Successfully.");

            Console.WriteLine();

         
            center.PrintAllShipments();

          
            Console.WriteLine();
            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment searchedShipment = center[searchCode];
            if (searchedShipment != null)
            {
                Console.WriteLine("\nShipment Found:\n");
                searchedShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("\nShipment Not Found.");
            }

           
            Console.WriteLine();
            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine("\nShipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to Remove Shipment.");
            }

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==================================================");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Shipment s = center[i];
                if (s != null && !string.IsNullOrEmpty(s.TrackingCode))
                {
                    Console.WriteLine($"Tracking Code : {s.TrackingCode}");
                    Console.WriteLine("...");
                    Console.WriteLine();
                }
            }

         
      

            #endregion
        }
    }
}
