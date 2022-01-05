using System;

Byte number;

/**
 * We cannot use an variable before initialization
 * Otherwise we will get an error
 */
number = 5;

Console.WriteLine("Number: {0}", number);

// Declating a Byte number
byte Byte_num = 125;
// Declaring a Short number
short Short_num = 252;
// Declaring a Int number
int Int_num = 17750;
// Declaring a native Int number
nint NInt_num = 770056;
// Declaring a Long number
long Long_num = 17756680;

Console.WriteLine($"{Byte_num} {Short_num} {Int_num} {NInt_num} {Long_num}");

// Declaring a Float number
float Float_num = 17.75f;
// Declaring a Double number
double Double_num = 17.75;
// Declaring a Decimal number
decimal Decimal_num = 17.75m;

Console.WriteLine($"{Float_num} {Double_num} {Decimal_num}");

// Declaring a Charracter
char Char_num = 'A';
// Declaring a String
string String_num = "Jolly";

Console.WriteLine($"{Char_num} {String_num}");

// Declaring a Boolean
bool Boolean_num = true;

Console.WriteLine($"{Boolean_num}");




