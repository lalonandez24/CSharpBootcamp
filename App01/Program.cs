// See https://aka.ms/new-console-template for more information

/*
 * Many lines comments
 */

// One line comment

//Data
/*
 * VALUE TYPE
 * Built in Type:
 * int short long char float double bool byte decimal
 * 
 * User Defined Type:
 * struct
 * enum
 * 
 * REFERENCE TYPE
 * 
 *Build in Type:
 *object string dynamic
 *
 *User defined Type:
 *class interface array delegate
 *
 *Diff Value and Reference?
 *A: En C#, la diferencia fundamental entre tipos de valor y tipos de referencia 
 *radica en cómo se almacenan en memoria y cómo se comportan al pasarlos a 
 *funciones o asignarlos a otras variables. Los tipos de valor se almacenan 
 *directamente en la memoria (generalmente en la pila), mientras que los tipos 
 *de referencia almacenan una referencia (dirección de memoria) a un objeto en el montón
*/

string name = "Eduardo Hdez";
var url = "linkedil.com";


Console.WriteLine("Hello, World! My name is "+ name + " url: " +url);

int myInt = 100;
float myFloat = 2.36f;
double myDouble = 923.225;
decimal myDecimal = 487.567m;
byte myByte = 250;
bool myBoolean = false;
string myString = "My string";
char myChar = 'H';

const int myCons = 500;

//You cannot Do:
//myCons = 100;

myInt = 200;

//Need "?" to make them null
bool? myNullBoll = null;
string myNullString = null;




/*
Algorithm 

1.- Clien type a number X
2.- Client type second number Y
3.- Program capture this values and save them on the var.
And choose if wants to sum, substract, multiply or divide   
4.- Program makes the math
5.- Program print the results
*/
Console.WriteLine("Type the first number");
var firstNumberString = Console.ReadLine();

Console.WriteLine("Write second number");
var secondNumberString = Console.ReadLine();
var secondNumberInt = 0;

//IF Activity
//VALIDATE
if (string.IsNullOrEmpty(firstNumberString))
{
    Console.WriteLine("The value is empty or null");
    return;
}
int firstNumberInt = 0;
if (!int.TryParse(firstNumberString, out firstNumberInt) )
{
    Console.WriteLine("This is not a number");
    return;
}

if (string.IsNullOrEmpty(secondNumberString))
{
    Console.WriteLine("The value is empty or null");
    return;
}
if(!int.TryParse(secondNumberString, out secondNumberInt))
{
    Console.WriteLine("This is not a number");
    return;

}

Console.WriteLine("Select: 1)Sum 2)Subs. 3)Mult 4) Div.");

int operationType = int.TryParse(Console.ReadLine(), out operationType)? operationType: 0;

switch(operationType)
{
    case 1:
        var resultPlus = firstNumberInt + secondNumberInt;
        Console.WriteLine($"You selected Sum {firstNumberInt} + {secondNumberInt} = {resultPlus}" );
        break;
    case 2:
        var resultSubstraction = firstNumberInt - secondNumberInt;
        Console.WriteLine($"You selected Substraction {firstNumberInt} - {secondNumberInt} = {resultSubstraction}");
        break;
    case 3:
        var resultMultiplication = firstNumberInt * secondNumberInt;
        Console.WriteLine($"You selected Multiplication {firstNumberInt} * {secondNumberInt} = {resultMultiplication}");
        break;
    case 4:
        var resultDiv = secondNumberInt != 0 ? (double)firstNumberInt / secondNumberInt : 0;
        Console.WriteLine($"You selected Division {firstNumberInt} / {secondNumberInt} = {resultDiv}");
        break;
    default:
        Console.WriteLine("Invalid option");
        return;
}
if (firstNumberInt >= 100)
{
    Console.WriteLine("Number is greater than or equal to 100");
}
else
{
    Console.WriteLine("Number is less than 100");
}

if (firstNumberInt <= 10)
{
    Console.WriteLine("Number is less than or equal to 10");
} 
else if (firstNumberInt > 10 && firstNumberInt <=20)
{
    Console.WriteLine("Number is greater than 10 and less than or equal to 20");
}
else
{
    Console.WriteLine("Number is greater than 20");
}
    //var firstNumberInt = int.Parse(firstNumberString!);



    







