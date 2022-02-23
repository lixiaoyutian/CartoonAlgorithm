using static System.Console;

WriteLine(GCD(25, 10));

int GCD(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    if ((a & 1) == 0 && (b & 1) == 0)
    {
        return GCD(a >> 1, b >> 1);
    }
    else if ((a & 1) == 0 && (b & 1) != 0)
    {
        return GCD(a >> 1, b);
    }
    else if ((a & 1) == 0 && (b & 1) != 0)
    {
        return GCD(a, b >> 1);
    }
    else
    {
        int big = a > b ? a : b;
        int small = a < b ? a : b;
        return GCD(small, big - small);
    }
}