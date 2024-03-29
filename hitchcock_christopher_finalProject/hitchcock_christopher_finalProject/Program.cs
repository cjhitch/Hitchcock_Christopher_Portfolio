﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace hitchcock_christopher_finalProject
{
    internal class Program
    {
        // private variable used in while loop to keep menu running
        private bool _runMenu = true;
        private List<GroceryItem> groceryCart = new List<GroceryItem>();
        static void Main(string[] args)
        {
            // add new instance of program
            Program inst = new Program();
            // set color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            // welcome to the program
            Console.WriteLine("Welcome to the Grocery Cart Calculator!");
            Console.ResetColor();
            // start menu
            inst.Menu();
        }

        // menu for the program
        void Menu()
        {
            // run menu unless user selects exit to leave program
            while (_runMenu)
            {
                string input;
                string switchStatement = Validation.GetString(
                    $"{Utility.ColorCyan("------------------------------------\r\n--------------- Menu ---------------\r\n------------------------------------\r\n")}{Utility.ColorBlue("\r\n1.) Add Item\r\n2.) View Cart\r\n3.) Remove Item\r\n4.) View Total\r\n5.) Save Shopping List\r\n0.) Exit\r\n")}{Utility.ColorCyan("\r\nMake a selection: ")}",input = Console.ReadLine());
                // use switch statement for menu and use validation prompt to make sure user didn't leave blank
                switch (switchStatement)
                {
                    // case for add item - customer can use 1, 1.) or add item
                    case "1":
                    case "1.)":
                    case "add item":
                    {
                        // call add item method
                        AddItem();
                        // break switch statement
                        break;
                    }
                    // case for view cart - customer can use 2, 2.) or view cart
                    case "2":
                    case "2.)":
                    case "view cart":
                    {
                        // call view cart method
                        ViewCart();
                        // break switch statement
                        break;
                    }
                    // case for remove item - customer can use 3, 3.) or remove item
                    case "3":
                    case "3.)":
                    case "remove item":
                    {
                        // call remove item method
                        RemoveItem();
                        // break switch statement
                        break;
                    }
                    // case for view total - customer can use 4 4.) or view total
                    case "4":
                    case "4.)":
                    case "view total":
                    {
                        // call view cart method
                        CalculateTotal();
                        // break switch statement
                        break;
                    }
                    case "5":
                    case "5.)":
                    case "save shopping list":
                    {
                        SaveList();
                        break;
                    }
                    // case to exit program - customer can use 0 0.) or exit
                    case "0":
                    case "0.)":
                    case "exit":
                    {
                        Utility.AnyKey("Press any key to exit the program. . .");
                        // set the switch statement to false allowing the program to exit
                        _runMenu = false;
                        // break switch statement
                        break;
                    }
                    // this will catch any errors not included in the menu - prompt user they've entered an invalid response and after a key prompt return to main menu
                    default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have entered an invalid response. ");
                        Console.ResetColor();
                        // wait for key response to return to main menu
                        Utility.AnyKey("\r\nPress any key to return to main menu. . .");
                        break;
                    }
                }
            }
        }
        // method to add item to cart
        void AddItem()
        {
            // capture name of item they would like to add
            string tempItem = Validation.GetString("\r\nPlease enter the name of the item you would like to add to your cart: ");
            // capture cost of single item they would like to add
            decimal tempCost = Validation.GetDecimal($"Enter the cost of {tempItem}. (must be above 0): $", 0);
            // boolean to stay in while loop until customer would like to stop adding items
            bool tempTrue = true;
            while (tempTrue)
            {
                // check if they need weigh or quantity
                Console.Clear();
                // new input to capture response
                string input;
                // build switch statement with colors
                string switchStatement = Validation.GetString(
                        $"{Utility.ColorCyan($"Are you buying {tempItem} as single, bulk, or per pound?\r\n")}" +
                        $"{Utility.ColorGrey($"\r\n1.) Single Item\r\n2.) Bulk Items\r\n3.) Per Pound\r\n\r\n")}" +
                        $"{Utility.ColorCyan("Make a selection: ")}".ToLower(), input = Console.ReadLine());
                switch (switchStatement)
                {
                    // case for single item
                    case "1":
                    case "1.)":
                    case "single item":
                    {
                        // add new grocery item from base class that is a single quantity
                        GroceryItem newItem = new GroceryItem(tempItem, tempCost);
                        // add new item to grocery cart list
                        groceryCart.Add(newItem);
                        // tell user the item was added
                        Console.WriteLine($"\r\n{tempItem} was added to your cart!");
                        break;
                    }
                    // case for multiple items
                    case "2":
                    case "2.)":
                    case "bulk items":
                    {                        
                        // get quantity of item
                        decimal tempQuant = Validation.GetDecimal($"\r\nEnter the quantity of the {tempItem} (must be more than 1): ", 1);
                        // instantiate new quantity item
                        GroceryItem newMultItem = new BulkItem(tempItem, tempCost, tempQuant);
                        // add new item to cart
                        groceryCart.Add(newMultItem);
                        // prompt user that the item was added
                        Console.WriteLine($"{tempItem} was added to your cart!");
                        break;
                    }
                    case "3":
                    case "3.)":
                    case "per pound":
                    {
                        // get weight of food
                        decimal tempWeight = Validation.GetDecimal($"\r\nEnter the weight of the {tempItem} (must be above 0): ", 0);
                        // instantiate new food item
                        GroceryItem newFood = new Food(tempItem, tempCost, tempWeight);
                        // add new food item to cart
                        groceryCart.Add(newFood);
                        // prompt user that the item was added
                        Console.WriteLine($"{tempItem} was added to your cart!");
                        break;
                    }
                    default:
                    {
                        // warning color
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have entered an invalid response. ");
                        Console.ResetColor();
                        // wait for key response to return to quantity menu
                        Utility.AnyKey("\r\nPress any key to return to add item menu. . .");
                        break;
                    }
                }

                string anotherItem = Validation.GetString("\r\nWould you like to add another item to cart? (Y or N) ", true);
                // check if user would like to add another item or not
                if (anotherItem != "y")
                {
                    // if they don't want to add a new item, break the while loop
                    tempTrue = false;
                }
                else
                {
                    Console.Clear();
                    // if they do want to add a new item, capture name and cost of new item
                    tempItem = Validation.GetString("Please enter the name of the new item you would like to add to your cart: ");
                    tempCost = Validation.GetDecimal($"Enter the cost of {tempItem}. (must be above 0) $", 0);
                }
            }
            // wait for key response to return to main menu
            Utility.AnyKey("Press any key to return to menu. . .");
        }
        // method to view all contents of the cart
        void ViewCart()
        {
            // make sure the cart isn't empty
            if (groceryCart.Count < 1) 
            {
                Console.WriteLine("You need to add items first!");
            }
            // if cart has items
            else
            {
                DisplayCart();
            }
            Utility.AnyKey("Press any key to return to menu. . .");
        }
        // method to remove item from cart
        void RemoveItem()
        {
            // make sure the cart isn't empty
            if (groceryCart.Count < 1)
            {
                Console.WriteLine("You need to add items first!");
            }
            // if cart has items
            else
            {
                int i = 1;
                foreach (GroceryItem item in groceryCart)
                {
                    Console.WriteLine($"{i}.) {item.Name}");
                    i++;
                }
                int removeAtIndex = Validation.GetInt("\r\nPlease select the item # you would like to remove from your cart: ", 1, groceryCart.Count);
                Utility.ColorRed($"Removed {groceryCart[removeAtIndex-1].Name} from cart.");
                groceryCart.RemoveAt(removeAtIndex-1);

            }
            // wait for key response to return to main menu
            Utility.AnyKey("Press any key to return to menu. . .");
        }
        // method to calculate entire total
        void CalculateTotal()
        {
            // make sure the cart isn't empty
            if (groceryCart.Count < 1)
            {
                Console.WriteLine("You need to add items first!");
            }
            // if cart has items
            else
            {
                // use method to get subtotal
                decimal subTotal = CalculateSubtotal();
                // round the value to the nearest hundreth
                subTotal = Math.Round(subTotal, 2);
                // use method to calculate tax
                decimal tax = CalculateTax(subTotal);
                // round the value to the nearest hundreth
                tax = Math.Round(tax, 2);
                // add sub and tax to get total
                decimal total = subTotal + tax;
                Console.WriteLine($"\r\n\r\n------------------------------------------------------------- Grocery Cart ------------------------------------------------------------" +
                "\r\n" +
                    "|    **  Sub Total  **                                                                                                                |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}",subTotal)}                                                                                                                     \r\n" +
                    "|    **  Tax    **                                                                                                                    |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}",tax)}                                                                                                                      \r\n" +
                    "|    **  Total  **                                                                                                                    |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}",total)}                                                                                                                      ");
            }
            // wait for key response to return to main menu
            Utility.AnyKey("Press any key to return to menu. . .");
        }
        // method displaying cart items
        void DisplayCart()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------\r\n" +
                              "--------------- Cart ---------------\r\n" +
                              "------------------------------------\r\n" +
                              "\r\n" +
                              "| ---------- Item ---------- | | ----- Cost ----- | | -- Quantity -- | | ----- Total ----- |");
            Console.ResetColor();
            string name;
            string cost;
            string quantity;
            string total;
            // iterate through each item in the cart
            foreach (GroceryItem item in groceryCart)
            {
                name = "| "+item.Name;
                cost = null;
                quantity = null;
                total = "  | $"+item.Cost.ToString();
                Console.Write("\r\n");
                // display name of item
//                Console.Write("Item: "+item.Name);
                // check if item is implementing ITotal
                if (item is ITotal)
                {
                    // check if item is food
                    if (item is Food)
                    {
                        quantity = " | "+item.Quantity.ToString()+"lbs.";
                        // display item weight
//                        Console.Write(" Item Weight: "+item.Quantity);
                    }
                    // if not food, it is bulk item
                    else
                    {
                        quantity = " | "+item.Quantity.ToString();
                        // display item quantity
//                        Console.Write(" Item Quantity: "+item.Quantity);
                    }
                    
                    // display single item and total
//                    Console.Write(" Single Item Cost: " + item.Cost + " Total: " + item.TotalCost);
                    cost = " | $" + item.Cost.ToString();
                    total = "  | $" + item.TotalCost.ToString();
                }
                string fullItem = string.Format("{0,-30}{1,-21}{2,-18}{3,-21}", name, cost, quantity, total);
                Console.WriteLine("| -------------------------- | | ---------------- | | -------------- | | ----------------- |");
                Console.WriteLine(fullItem);
            }
            
        }
        // method for saving the file to output folder
        void SaveList()
        {
            // make sure the cart isn't empty
            if (groceryCart.Count < 1)
            {
                Console.WriteLine("You need to add items first!");
            }
            else
            {
                // using datetime to denote the order these were built in
                string outputFolder = @"..\..\..\Output";
                string filename = $"\\grocery-list-{DateTime.Now.ToString("MM-dd-yyy-HH-mm-ss")}.txt";
                Directory.CreateDirectory(outputFolder);
                string groceryList = null;

                groceryList +=
                    $"-------- Shopping List     ----------------------------------------------------------------------------------------------------------------------" +
                    $"\r\n" +
                    $"\r\n{DateTime.Now.ToString("MM/dd/yyyy H:mm")}" +
                    $"\r\n" +
                    $"\r\n";
                foreach (GroceryItem cartItem in groceryCart)
                {
                    groceryList +=
                        "\r\n---- Item ----------------------------------------------------------------------------------------------- Total -----------------------" +
                        "\r\n     " + cartItem;
                }

                decimal subTotal = CalculateSubtotal();
                subTotal = Math.Round(subTotal, 2);
                decimal tax = CalculateTax(subTotal);
                tax = Math.Round(tax, 2);
                decimal total = subTotal + tax;
                groceryList +=
                    "\r\n\r\n---------------------------------------------------------------------------------------------------------------------------------------" +
                    "\r\n" +
                    "|    **  Sub Total  **                                                                                                                |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}", subTotal)}                                                                                                                     \r\n" +
                    "|    **  Tax    **                                                                                                                    |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}", tax)}                                                                                                                      \r\n" +
                    "|    **  Total  **                                                                                                                    |\r\n" +
                    "-----|             |-------------------------------------------------------------------------------------------------------------------\r\n" +
                    $"     |  {string.Format("{0:C}", total)}                                                                                                                      ";

                using (StreamWriter receipt = new StreamWriter(outputFolder + filename))
                {
                    receipt.Write(groceryList);
                }

                Console.WriteLine("Your Grocery List has been saved! Thank you for using our program.");
            }

            Utility.AnyKey("Press any key to return to the main menu. . .");
        }
        decimal CalculateSubtotal()
        {
            decimal subTotal = 0;
            foreach (GroceryItem item in groceryCart)
            {
                if (item is ITotal)
                {
                    // subtotal if item uses interface
                    subTotal += item.TotalCost;
                }
                else
                {
                    // subtotal if item doesn't user interface
                    subTotal += item.Cost;
                }
            }
            return subTotal;
        }
        decimal CalculateTax(decimal sub)
        {
            // get tax
            decimal tax = sub * .0825m;
            return tax;
        }
    }
}