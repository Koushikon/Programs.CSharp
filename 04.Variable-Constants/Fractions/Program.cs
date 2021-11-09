using System;

/*************
 * Floating-point type
*************/

float car_payment = 401.23f; // Or like this
// System.Single car_payment = 401.23f;
Console.WriteLine($"My car payment: {car_payment}");

/*************
 * Double type
*************/

double pi = 3.14159d; // Or like this
// System.Double pi = 3.14159d;
Console.WriteLine($"The pi is: {pi}");

/*************
 * Double type
*************/
decimal bec = 2.17750891532m; // Or like this
// System.Decimal bec = 2.17750891532m;
Console.WriteLine($"The dec is: {bec}");

Console.WriteLine(" = = = New = = = \n");

double a1 = 1.0054;
decimal b1 = 2.1775089153246565465465234m;

// With (double) you can convert from decimal or float to double
Console.WriteLine(a1 + (double)b1);
Console.WriteLine((decimal)a1 + b1);

/**
 * d or D suffix for double (Optional)
 * f or F suffix for float (Must be used)
 * m or M suffix for decimal (Must be used)
**/

double d = 3D;
d = 4d;
d = 3.934_001;

float f = 3_000.5F;
f = 5.4f;

decimal myMoney = 3_000.5m;
myMoney = 400.75M;

Console.WriteLine(d);
Console.WriteLine(f);
Console.WriteLine(myMoney);

Console.WriteLine(" = = = New = = = \n");

/**
 * The preceding example also shows the use of _ as a digit separator
 * Which is supported starting with C# 7.0.
**/

double d2 = 0.42e2;
Console.WriteLine(d2); // output 42

float f2 = 134.45E-2f;
Console.WriteLine(f2); // output: 1.3445

decimal m2 = 1.1_775_089_153_246_565_465_465_234m;
Console.WriteLine(m2); // output: 1.1775089153246565465465234

Console.WriteLine(" = = = New = = = \n");

// Scientific notation 'e' expression
double number5 = 192400023;
double number6 = 1.192400023e8;
double number7 = 1.1924e8;
double number8 = 0.00000000003498;
double number9 = 003.498e-11;

Console.WriteLine($"Scientific notation: {number5}");
Console.WriteLine($"Scientific notation: {number6}");
Console.WriteLine($"Scientific notation: {number7}");
Console.WriteLine($"Scientific notation: {number8}");
Console.WriteLine($"Scientific notation: {number9}");

Console.WriteLine(" = = = New Conversions = = = \n");

f2 = 134.45E-2f;
Console.WriteLine(f2);          // With float output: 1.3445
Console.WriteLine((double)f2);  // With double output: 1.344499945640564
Console.WriteLine((decimal)f2); // With decimal output: 1.3445

d2 = 0.4592e2;
Console.WriteLine(d2);          // With double output: 45.92
Console.WriteLine((float)d2);   // With float output: 45.92
Console.WriteLine((decimal)d2); // With decimal output: 45.92

m2 = 1.1_775_089_153_246_565_465_465_234m;
Console.WriteLine(m2);          // With decimal output: 1.1775089153246565465465234
Console.WriteLine((float)m2);   // With float output: 1.177509
Console.WriteLine((double)m2);  // With double output: 1.1775089153246565 

Console.WriteLine(" = = = New Divisions = = = \n");

double number10 = 5.6;
double number11 = 0; // to 0
double number12 = 0; // to 0

double result = number10 / number11;

// inf ∞ - Positive or Negative Infinity
Console.WriteLine($"{number10} / {number11} yelds = {result}\n{result} + {number10} yelds = {result + number10}");

// Nan - Not a number
result = number11 / number12;
Console.WriteLine($"{number11} / {number12} = {result}");
