// Khai Ha
// IT112 
// NOTES:
// Program.cs //
// Make shipper, then added a max counter for total amount of items, it is also how I break out of loops at the end. Prompt user for input, made string option
// to capture and navigate the program. Users are asked to punch in numbers for options that's on the screen. Had a few ifs, if max is less than 10 I would
// show the original UI. If it's equal, I would remove the add options just leaving the list shipment, and compute shipcost. If Shipcost is ever invoke, it
// set max= -1 which will enter the last if, where it says press any key to end program.

// Shipper //
// Shipper we have the Add method, but firs ti created a List<IShippable> to hold 10 things only as well. In the program.cs we have it so if 1 is chosen we
// invoke the shipper.add(corresponding product) When we do, we invoke add the item that's in a class of their own. So each product class, has a get for shipment
// cost, and a get for what the item is. A key and a value, is save into the slot in the list. We repeat this for each product we provided. Then we have the
// the 5 option, which is the list shipment items.

// In ListShipmentItems we made a dictionary, to count how many of each item we have. So for each item in the list, it goes through and check for each
// item and how may of each there are in there. Keeping track as a string and a in. After it counts runs through the loop, it display how it. We have a
// parameter that if there's more than 1 item add an "s", and if the item is Cracker, changes it to the plural on detection.

// In Compute Shipping Charges, we have a decimal Totalcost set at 0, then loop through each item we got from intime in _product. We add the shipcost to the
// total cost variable. and return the cost to Program.cs to display.

// The interface looks for product and cost, and each class holds the value and key to each items.

namespace Ha_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            int max = 0;

            Console.WriteLine("Amazon Prime");
            while (true)
            {
                if (max < 10)
                {
                    Console.WriteLine("Choose from the following options:(Enter Number)");
                    Console.WriteLine("1. Add a Bicycle to the shipment");
                    Console.WriteLine("2. Add a Baseball Glove to the Shipment");
                    Console.WriteLine("3. Add a Crackers to the shipment");
                    Console.WriteLine("4. Add a Lawnmower to the shipment");
                    Console.WriteLine("5. List Shipment Items");
                    Console.WriteLine("6. Compute Shipping Charges");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to add to cart?");
                            Console.WriteLine("1. Yes   2. No");
                            option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    Console.Clear();
                                    confirmAdded(shipper.Add(new Bicycles()));
                                    max++;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("No new items were added");
                                    break;
                            }
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to add to cart?");
                            Console.WriteLine("1. Yes   2. No");
                            option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    Console.Clear();
                                    confirmAdded(shipper.Add(new BaseballGloves()));
                                    max++;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("No new items were added");
                                    break;
                            }
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to add to cart?");
                            Console.WriteLine("1. Yes   2. No");
                            option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    Console.Clear();
                                    confirmAdded(shipper.Add(new Crackers()));
                                    max++;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("No new items were added");
                                    break;
                            }
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Are you sure you want to add to cart?");
                            Console.WriteLine("1. Yes   2. No");
                            option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    Console.Clear();
                                    confirmAdded(shipper.Add(new LawnMowers()));
                                    max++;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("No new items were added");
                                    break;
                            }
                            break;
                            case "5":
                            Console.Clear();
                            Console.WriteLine("Shipment manifest:");
                            (int itemValue, string itemName) = shipper.ListShipmentItems();

                            Console.WriteLine($"{itemValue} {itemName}");

                            break;
                            case "6":
                            Console.Clear();
                            Console.WriteLine("This is the total shipment cost " + shipper.ComputeShippingCharges());
                            max = -1;
                            break;
                    }



                }
                if (max == 10)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Maximum number of items reached. " + max);
                        Console.WriteLine("1. List Shipment Items");
                        Console.WriteLine("2. Compute Shipping Charges");

                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                Console.Clear();
                                shipper.ListShipmentItems();
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("This is the total shipment cost " + shipper.ComputeShippingCharges());
                                max = -1;
                                break;
                        }
                        break;
                    }
                }
                if(max <= -1)
                {
                    Console.WriteLine("Press any key to close program");
                    Console.ReadLine();
                    break;
                }

            }

        }
        public static void confirmAdded(string ConItem)
        {
            Console.Clear();
            Console.WriteLine($"1 {ConItem} has been added");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}