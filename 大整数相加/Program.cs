using System;
using static System.Console;

WriteLine(bigNumberSum("426709752318", "95481253129"));

string bigNumberSum(string num1, string num2)
{
    if (num1.Length == 0 || num2.Length == 0)
    {
        return num1.Length == 0 ? num2 : num1;
    }
    int MinLength = num1.Length > num2.Length ? num2.Length : num1.Length;
    int MaxLength = num1.Length > num2.Length ? num1.Length + 1 : num2.Length + 1;
    char[] num1char = num1.ToCharArray();
    char[] num2char = num2.ToCharArray();
    Array.Reverse(num1char);
    Array.Reverse(num2char);
    int[] num1int = new int[MaxLength];
    Array.ConvertAll(num1char, s => Convert.ToInt32(s - '0')).CopyTo(num1int, 0);
    int[] num2int = new int[MaxLength];
    Array.ConvertAll(num2char, s => Convert.ToInt32(s - '0')).CopyTo(num2int, 0);
    int[] numSum = new int[MaxLength];
    for (int i = 0; i < MaxLength; i++)
    {
        int temp = numSum[i];
        temp += num1int[i];
        temp += num2int[i];
        if (temp - 10 >= 0)
        {
            temp -= 10;
            numSum[i + 1] = 1;
        }
        numSum[i] = temp;
    }
    for (int i = MaxLength - 1; i > 0; i--)
    {
        if (numSum[i] != 0)
        {
            return string.Join("", numSum.Reverse()).Remove(0, MaxLength - 1 - i);
        }
    }
    return null;
}
