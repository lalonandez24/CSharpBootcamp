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
4.- Program makes the math
5.- Program print the results
*/
Console.WriteLine("Type the first number");
var firstNumberString = Console.ReadLine();

//IF Activity


if (string.IsNullOrEmpty(firstNumberString))
{
    Console.WriteLine("The value is empty or null");
    return;
}
int firstNumberInt = 0;
if (!int.TryParse(firstNumberString, out firstNumberInt) )
{
    Console.WriteLine("Thi is not a number");
    return;
}
//var firstNumberInt = int.Parse(firstNumberString!);




Console.WriteLine("Write second number");
var secondNumberString = Console.ReadLine();
var secondNumberInt = int.Parse(secondNumberString!);

var resultPlus = firstNumberInt + secondNumberInt;
Console.WriteLine("The result of + is: " + resultPlus);

var resultMinus = firstNumberInt - secondNumberInt;
Console.WriteLine("The result of - is: " + resultMinus);

var resutlMult = firstNumberInt * secondNumberInt;
Console.WriteLine("The result of the * is: " + resutlMult);

var resultDiv = firstNumberInt / secondNumberInt;
Console.WriteLine("The result of the / is: " + resultDiv);

//ASSIGNED
resultPlus = firstNumberInt;
resultPlus += secondNumberInt;
Console.WriteLine("The result of the + assigned is: "+resultPlus);








