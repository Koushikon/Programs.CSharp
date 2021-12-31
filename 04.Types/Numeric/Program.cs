using System;

/*************
* integer type
*************/

// Number system Initialized variables
int number1 = 15;           // Wtire in Decimal or Default form || 0 ~ 9
System.Int32 number2 = 15;  // Its the same as above
int number3 = 0X0f;         // Write in Hexa-decimal form || 0 ~ F
int number4 = 0b00001111;   // Write in Binary from || 0 or 1

Console.WriteLine( "{0}\t{1}\t{2}\t{3}", number1, number2, number3, number4);

// nint num1o1 = 1;
// System.IntPtr num1o2 = 0x1;

// 2Bytes - Short integer
// short short_var {-32768};
// short int short_int {455};
// signed short signed_short {122};
// signed short int signed_short_int {-456};
// unsigned short unsigned_short {456};
// unsigned short int unsigned_short_int {456};

// 4Byte - integer
// int int_var {55};
// signed signed_var {666};
// signed int signed_int {-777};
// unsigned unsigned_var {777};
// unsigned int unsigned_int {777};

// 4 or 8 Byte - long integer
// long long_var {25'100'000};
// long int long_int {25'100'000};
// signed long int signed_long_int {-25'100'000};
// unsigned long unsigned_long {25'100'000};
// unsigned long int unsigned_long_int {25'100'000};

// Working with long long not working properly
// 8Byte - long long integer
// long long long_long_var {7'610'100'000'000'000'100};
// long long int long_long_int {7'610'100'000'000'000'100};
// signed long long int signed_long_long_int {-7'610'100'000'000'000'100};
// unsigned long long unsigned_long_long {7'610'100'000'000'000'100};
// unsigned long long int unsigned_long_long_int {7'610'100'000'000'000'100};

// std::cout << short_var << " " << sizeof(short_var) << " "
//           << short_int << " " << sizeof(short_int) << " "
//           << signed_short << " " << sizeof(signed_short) << " "
//           << signed_short_int << " " << sizeof(signed_short_int) << " "
//           << unsigned_short << " " << sizeof(unsigned_short) << " "
//           << unsigned_short_int << " " << sizeof(unsigned_short_int) << " "
//           << "\n";

// std::cout << int_var << " " << sizeof(int_var) << " "
//           << signed_var << " " << sizeof(signed_var) << " "
//           << signed_int << " " << sizeof(signed_int) << " "
//           << unsigned_var << " " << sizeof(unsigned_var) << " "
//           << unsigned_int << " " << sizeof(unsigned_int) << " "
//           << "\n";

// std::cout << long_var << " " << sizeof(long_var) << " "
//           << long_int << " " << sizeof(long_int) << " "
//           << signed_long_int << " " << sizeof(signed_long_int) << " "
//           << unsigned_long << " " << sizeof(unsigned_long) << " "
//           << unsigned_long_int << " " << sizeof(unsigned_long_int) << " "
//           << "\n";

// std::cout << long_long_var << " " << sizeof(long_long_var) << " "
//           << long_long_int << " " << sizeof(long_long_int) << " "
//           << signed_long_long_int << " " << sizeof(signed_long_long_int) << " "
//           << unsigned_long_long << " " << sizeof(unsigned_long_long) << " "
//           << unsigned_long_long_int << " " << sizeof(unsigned_long_long_int) << " "
//           << "\n";

/*************
 * Overloading value warning example
*************/

// short value1 {30000};
// short value2 {1000};
// short product { value1 * value2 };
// std::cout << "The product of " << value1 << " and " << value2 << " is " << product << std::endl;
