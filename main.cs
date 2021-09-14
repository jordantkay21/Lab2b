using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Enter a number:");
    int firstNumber=Convert.ToInt32 (Console.ReadLine());

    Console.Write ("Enter another number:");
    int secondNumber=Convert.ToInt32 (Console.ReadLine());

    int sum= firstNumber+secondNumber;
    Console.WriteLine ("Sum = " +sum);

    int diff= firstNumber-secondNumber;
    Console.WriteLine ("Diff = " +diff);

    int product= firstNumber*secondNumber;
    Console.WriteLine ("Product = " +product);

    int quotient= firstNumber/secondNumber;
    Console.WriteLine ("quotient = " +quotient);

    int remainder= firstNumber%secondNumber;
    Console.WriteLine ("remainder = " +remainder);
  }
}