// Row 0: Even numbers
// Row 1: Odd numbers
int[][] numberMatrix = new int[][]
{
    new int[] { 2, 4, 6, 8, 10 },
    new int[] { 1, 3, 5, 7, 9 }
};

Console.WriteLine("The number matrix has been initialized.");

{
//Digit 1
int digit1 = numberMatrix [1][3];
Console.WriteLine ($"The Extract Digit from Digit 1 is: {digit1}");

//Digit 2
int digit2 = numberMatrix [0][0];
Console.WriteLine ($"The Extract Digit from Digit 1 is: {digit2}");

//Digit 3
int digit3 = numberMatrix [1][4];
Console.WriteLine ($"The Extract Digit from Digit 1 is {digit3}");

//Combining all Digits and displaying them as password
string thekey = string.Format ("{0}{1}{2}", digit1 ,digit2, digit3);
Console.WriteLine ($"The Password are: {thekey}");
}