using System;

class Program {
  public static void Main (string[] args)
  {

    double price;
    double total;
    string name;
    int quantity;


    Console.WriteLine("Enter the name of the item: ");
      name = Console.ReadLine();

    Console.WriteLine("Enter the quantity: ");
      quantity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the price of the product: ");
      price = Double.Parse(Console.ReadLine());

    total = price * quantity;

    Console.WriteLine("Your total is: " + total);

  }
}