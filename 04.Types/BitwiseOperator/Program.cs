
// Learn Bitwise Operator use
// Learn Source: https://www.programiz.com/csharp-programming/bitwise-operators

int firstNumber = 14;   // 00001110
int secondNumber = 11;  // 00001011
int result;

/***
 * Bitwise OR Operator i.e. |
 * 00001110 - 14
 * 00001011 - 11
 * --------
 * 00001111 - 15
 */
result = firstNumber | secondNumber;
Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);


/***
 * Bitwise AND Operator i.e. &
 * 00001110 - 14
 * 00001011 - 11
 * --------
 * 00001010 - 10
 */
result = firstNumber & secondNumber;
Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);


/***
 * Bitwise Exclusive OR (XOR) Operator i.e. ^
 * 00001110 - 14
 * 00001011 - 11
 * --------
 * 00000101 - 5
 */
result = firstNumber ^ secondNumber;
Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result);


/***
 * Bitwise Complement Operator i.e. ~
 * But it shows the 2's Complement representation
 *
 * In 2's Complement:
 * first switch the bit as per the 1's Complement (~N)
 * Next -(~N + 1) as per the 2's Complement and the N here is 1's Complement value
 * Summary: Its this: -(~(~N) + 1)
 *
 * 00001110 - 14
 * --------
 * 11110001 - 1s Complement value of 14 which is 241, Also we're expecting that would be the answer
 * 00001111 - 2s Complement value of 241 which is -15
 */
result = 0;
result = ~firstNumber;
Console.WriteLine("~ {0} = {1}", firstNumber, result);


/***
 * Bitwise Left Shift Operator i.e. <<
 * Style apply Binary to Decimal Convertion for quick
 *
 * 00001110 - 14 << 2
 * --------
 * 00111000 - 56
 *
 * 00001011 - 11 << 1
 * --------
 * 00010110 - 22
 */
Console.WriteLine("{0} << 2 = {1} ", firstNumber, firstNumber << 2);
Console.WriteLine("{0} << 1 = {1} ", secondNumber, secondNumber << 1);


/***
 * Bitwise Right Shift Operator i.e. >>
 * Style apply Binary to Decimal Convertion for quick
 *
 * 00001110 - 14 >> 2
 * --------
 * 00111000 - 3
 *
 * 00001011 - 11 >> 1
 * --------
 * 00010110 - 5
 */
Console.WriteLine("{0} >> 2 = {1} ", firstNumber, firstNumber >> 2);
Console.WriteLine("{0} >> 1 = {1} ", secondNumber, secondNumber >> 1);