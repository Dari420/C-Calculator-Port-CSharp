using System;
using System.Linq;
using System.Text.RegularExpressions;

class MainClass {
    public static void Main () {
        Calculator c = new Calculator();
        while (true) {
            c.choice();
            c.AskAgain();
        }
    }
}

public class Calculator {
    public int choice() {
        while (true) {
            string CalChoice = "";
            Console.WriteLine("Choose Option (case sensitive!):");
            Console.WriteLine("a) Addition");
            Console.WriteLine("b) Subtraction ");
            Console.WriteLine("c) Multiplication");
            Console.WriteLine("d) Division");
            Console.WriteLine("e) Square Roots");
            Console.WriteLine("f) Squares");
            CalChoice = Console.ReadLine();
            Operations cop = new Operations();
            if (CalChoice != "a" && CalChoice != "b" &&
                CalChoice != "c" && CalChoice != "d" &&
                CalChoice != "e" && CalChoice != "f") {
                Console.WriteLine("Invalid input! please enter a, b, c, e, f, ");
            }
            else {
                while (true) {
                    string NumA = "";
                    Console.WriteLine("Enter first number:");
                    NumA = Console.ReadLine();
                    if (NumA.All(char.IsDigit)) {
                        if (CalChoice == "e" || CalChoice ==  "f") {
                            switch (CalChoice) {
                                case "e":
                                    cop.Sqrt(Fparse(NumA));
                                    return 0;
                                case "f":
                                    cop.Squares(Fparse(NumA));
                                    return 0;
                                default:
                                    Console.WriteLine("Fatal error");
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        else {

                        }
                        while (true) {
                            string NumB = "";
                            Console.WriteLine("Enter second number:");
                            NumB = Console.ReadLine();
                            if (NumB.All(char.IsDigit)) {
                                switch (CalChoice) {
                                    case "a":
                                        cop.Addition(Fparse(NumA), Fparse(NumB));
                                        return 0;
                                    case "b":
                                        cop.Subtraction(Fparse(NumA), Fparse(NumB));
                                        return 0;
                                    case "c":
                                        cop.Multiplication(Fparse(NumA), Fparse(NumB));
                                        return 0;
                                    case "d":
                                        cop.Division(Fparse(NumA), Fparse(NumB));
                                        return 0;
                                    default:
                                        Console.WriteLine("Fatal error");
                                        Environment.Exit(0);
                                        break;    
                                }
                            }
                            else {
                                Console.WriteLine("Invalid entry! Please enter a number");
                                continue;
                            }
                        }
                    }
                    else {
                        Console.WriteLine("Invalid entry! Please enter a number");
                        continue;
                    }
                }
            }
        }
    }  
    public int AskAgain() {
        while (true) {
            string YesNo = "";
            Console.WriteLine("Go again? y/n");
            YesNo = Console.ReadLine();
            switch (YesNo) {
                case "y":
                    return 0;
                case "n":
                    Console.WriteLine("Closing calculator");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid entry! Please choose y or n");
                    break;
            }
        }
    }
    public float Fparse(string floatin) {
        return float.Parse(floatin, System.Globalization.CultureInfo.InvariantCulture);
    }
}


public class Operations {
    public void Addition(float num1, float num2) {
        Console.WriteLine((num1 + num2));
    }
    public void Subtraction(float num1, float num2) {
        Console.WriteLine((num1 - num2));
    }
    public void Multiplication(float num1, float num2) {
        Console.WriteLine((num1 * num2));
    }
    public void Division(float num1, float num2) {
        Console.WriteLine((num1 / num2));
    }
    public void Sqrt(float num1) {
        Console.WriteLine(Math.Sqrt(num1));
    }
    public void Squares(float num1) {
        Console.WriteLine(num1 * num1);
    }
}