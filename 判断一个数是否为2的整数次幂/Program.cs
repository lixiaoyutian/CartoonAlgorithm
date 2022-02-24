using static System.Console;
WriteLine(isPowerOfTwo(1023));

bool isPowerOfTwo(int num)
{
    return (num & (num - 1)) == 0;
}