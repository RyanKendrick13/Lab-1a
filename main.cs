using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of item ");
    var name = Console.ReadLine();
    Console.WriteLine("Enter the quantity");
    double quanity = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter price ");
    double price = Convert.ToDouble(Console.ReadLine());
    double totalprice  = price * quanity;
    Console.WriteLine("The total price of"+ " "+ name + " "+ "=" +"$"+ totalprice);
    
    

    
  
  

  }
}