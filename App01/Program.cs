// * Many lines comments
// */

//// One line comment

////Data
// * VALUE TYPE
// * Built in Type:
// * int short long char float double bool byte decimal
// * 
// * User Defined Type:
// * struct
// * enum
// * 
// * REFERENCE TYPE
// * 
// *Build in Type:
// *object string dynamic
// *
// *User defined Type:
// *class interface array delegate
// *
// *Diff Value and Reference?
// *A: En C#, la diferencia fundamental entre tipos de valor y tipos de referencia 
// *radica en cómo se almacenan en memoria y cómo se comportan al pasarlos a 
// *funciones o asignarlos a otras variables. Los tipos de valor se almacenan 
// *directamente en la memoria (generalmente en la pila), mientras que los tipos 
// *de referencia almacenan una referencia (dirección de memoria) a un objeto en el montón
//*/

//string name = "Eduardo Hdez";
//var url = "linkedil.com";


//Console.WriteLine("Hello, World! My name is "+ name + " url: " +url);

//int myInt = 100;
//float myFloat = 2.36f;
//double myDouble = 923.225;
//decimal myDecimal = 487.567m;
//byte myByte = 250;
//bool myBoolean = false;
//string myString = "My string";
//char myChar = 'H';

//const int myCons = 500;

////You cannot Do:
////myCons = 100;

//myInt = 200;

////Need "?" to make them null
//bool? myNullBoll = null;
//string myNullString = null;




//Algorithm 

//1.- Clien type a number X
//2.- Client type second number Y
//3.- Program capture this values and save them on the var.
//And choose if wants to sum, substract, multiply or divide   
//4.- Program makes the math
//5.- Program print the results
//*/
//Console.WriteLine("Type the first number");
//var firstNumberString = Console.ReadLine();

//Console.WriteLine("Write second number");
//var secondNumberString = Console.ReadLine();
//var secondNumberInt = 0;

////IF Activity
////VALIDATE
//if (string.IsNullOrEmpty(firstNumberString))
//{
//    Console.WriteLine("The value is empty or null");
//    return;
//}
//int firstNumberInt = 0;
//if (!int.TryParse(firstNumberString, out firstNumberInt) )
//{
//    Console.WriteLine("This is not a number");
//    return;
//}

//if (string.IsNullOrEmpty(secondNumberString))
//{
//    Console.WriteLine("The value is empty or null");
//    return;
//}
//if(!int.TryParse(secondNumberString, out secondNumberInt))
//{
//    Console.WriteLine("This is not a number");
//    return;

//}

//Console.WriteLine("Select: 1)Sum 2)Subs. 3)Mult 4) Div.");

//int operationType = int.TryParse(Console.ReadLine(), out operationType)? operationType: 0;

//switch(operationType)
//{
//    case 1:
//        var resultPlus = firstNumberInt + secondNumberInt;
//        Console.WriteLine($"You selected Sum {firstNumberInt} + {secondNumberInt} = {resultPlus}" );
//        break;
//    case 2:
//        var resultSubstraction = firstNumberInt - secondNumberInt;
//        Console.WriteLine($"You selected Substraction {firstNumberInt} - {secondNumberInt} = {resultSubstraction}");
//        break;
//    case 3:
//        var resultMultiplication = firstNumberInt * secondNumberInt;
//        Console.WriteLine($"You selected Multiplication {firstNumberInt} * {secondNumberInt} = {resultMultiplication}");
//        break;
//    case 4:
//        var resultDiv = secondNumberInt != 0 ? (double)firstNumberInt / secondNumberInt : 0;
//        Console.WriteLine($"You selected Division {firstNumberInt} / {secondNumberInt} = {resultDiv}");
//        break;
//    default:
//        Console.WriteLine("Invalid option");
//        return;
//}
//if (firstNumberInt >= 100)
//{
//    Console.WriteLine("Number is greater than or equal to 100");
//}
//else
//{
//    Console.WriteLine("Number is less than 100");
//}

//if (firstNumberInt <= 10)
//{
//    Console.WriteLine("Number is less than or equal to 10");
//} 
//else if (firstNumberInt > 10 && firstNumberInt <=20)
//{
//    Console.WriteLine("Number is greater than 10 and less than or equal to 20");
//}
//else
//{
//    Console.WriteLine("Number is greater than 20");
//}
////var firstNumberInt = int.Parse(firstNumberString!);

//Loop to print 80 times the text: Hello World
//for (int i = 1; i <= 80; i++)
//{
//    Console.WriteLine($"{i} Hello World" );
//}

////The User type a number
//// The progam multiply by the first 10 numbers 
//// and print the result of each multiplication

//Console.WriteLine("Type a number to multiply by the first 10 numbers");
//var numberToMultiplyString = Console.ReadLine();
//if (string.IsNullOrEmpty(numberToMultiplyString))
//{
//    Console.WriteLine("The value is empty or null");
//    return;
//}
//int numberToMultiply = 0;
//if (!int.TryParse(numberToMultiplyString, out numberToMultiply))
//{
//    Console.WriteLine("This is not a number");
//    return;
//}
//for (int i = 1; i <= 10; i++)
//{
//    var result = numberToMultiply * i;
//    Console.WriteLine($"{numberToMultiply} * {i} = {result}");
//}

//The user types a number
// The program captures the number
// The program print max 100 numnbers bigger than the number typed by the user until it reaches 100
//RULE: The number does not haveto be greater or equals to 100

//Console.WriteLine("Type a number to print the first 100 numbers bigger than it");
//var numberWhileString = Console.ReadLine();
//if (string.IsNullOrEmpty(numberWhileString))
//{
//    Console.WriteLine("The value is empty or null");
//    return;

//}

//int numberWhile = 0;
//if (!int.TryParse(numberWhileString, out numberWhile))
//{
//    Console.WriteLine("This is not a number");
//    return;
//}

//if(numberWhile>= 100)
//{
//    Console.WriteLine("The number must be less than 100");
//    return;
//}

//while (numberWhile <= 100)
//{
//    Console.WriteLine(numberWhile);
//    numberWhile++;
//}

//Do While Loop
//The user types a number as many times as he wants to sum
//If the user types 0, the programs stops
//The program prints the sum of all numbers typed by the user
//EXCEPTIONS 


//int sum = 0;
//int numberToSum = 0;


//do
//{
//    Console.WriteLine("Type a number to sum, type 0 to stop");
//    try
//    {
//        numberToSum = int.Parse(Console.ReadLine()!);
//    }
//    catch (System.FormatException e)
//    {
//        Console.WriteLine($"This is not a valid number, please try again:" +$" {e.Message}");
//        if (e.Message is null)
//        {
//            throw;
//        }
//        continue; // Skip to the next iteration of the loop
//    }
//    sum += numberToSum;
//}
//while (numberToSum!=0);

//Console.WriteLine($"The sum of all numbers typed is: {sum}");


//The user types a number and the metodh print random numbers until it reaches the number typed by the user
//Methods can have default parameters and aswell assign parameters by name
//void PrintRandomNumbersUntil(int number, string message="deffault par.")
//{
//    var numberString = number;

//    var random = new Random();
//    for (int i = 0; i <= numberString; i++)
//    {
//        Console.WriteLine($"The param. is: {message}" +random.Next(1, 101)); // Generate a random number between 1 and 100

//    }
//}

//PrintRandomNumbersUntil(message:"BIG NUMBER", number:5);

// Objectiv: Calculate the salary of a worker
//1.- The method recieves the following parameters: salary, taxes, health insurance
//2.- The method calculates the total to receive the worker
//3.- The method returns the total to receive the worker

//int CalculateSalary(int salary, int taxesPercentaje, int health)
//{
//    int totalToReceive = salary - taxesPercentaje - health;
//    return totalToReceive;
//}
//int totalSalary = 0;
//totalSalary=CalculateSalary(1000, 200, 100);

//Console.WriteLine($"The total salary is:{totalSalary}");

//Tuples
//(int a, string b, bool c) myTuple = (1, "Hello", true);
//string myTupleB = myTuple.b;
//Console.WriteLine($"Tuple values: {myTuple.a}, {myTupleB}, {myTuple.c}");

//Objective: Register a new product on the system
//1.- The method recieves the following parameters: name, price, quantity
//2.- The program will capture the parameters and put a price that includes taxes
//3.- The method will register the product and return a tuple with the name, price and quantity
//4.- The program will print the tuple values

//Console.WriteLine("Register a new product on the system");
//Console.WriteLine("Product Name:");
//var productName = Console.ReadLine();

//Console.WriteLine("Product Price:");
//var productPrice = int.Parse(Console.ReadLine());

//Console.WriteLine("Product Quantity:");
//var productQuantity = int.Parse(Console.ReadLine());

//(double, int, string) RegisterProduct(string name, int price, int quantity)
//{
//    var finalPrice = price + (price * 0.16); // Assuming a 16% tax
//   return (price, quantity, name);
//}

//var tuple = RegisterProduct(productName!, productPrice, productQuantity);

//Console.WriteLine($"Product Registered: Name: {tuple.Item3}, Price: {tuple.Item1}, Quantity: {tuple.Item2}");

using App01;

//Accessor Modifiers
///*
/* * Accessor Modifiers
 * 
 * public: Accessible from anywhere
 * private: Accessible only within the class
 * protected: Accessible within the class and derived classes
 * internal: Accessible within the same assembly
 * protected internal: Accessible within the same assembly and derived classes
 * 
 * 
 * */
///*
Book book = new Book("C# Programming", "John Doe", 300);
var res1 = book.getDescription();
Console.WriteLine(res1);

book.setName("Java FullStack");
var res2 = book.getName();
Console.WriteLine(res2);