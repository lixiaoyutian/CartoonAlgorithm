using static System.Console;

WriteLine(removeKDigits("1593212", 3));
WriteLine(removeKDigits("30200", 1));
WriteLine(removeKDigits("10", 2));
WriteLine(removeKDigits("541270936", 3));



string removeKDigits(String num, int k)
{
    int newLength = num.Length - k;
    char[] array = num.ToCharArray();
    char[] stack = new char[array.Length];
    int top = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (top > 0 && stack[top - 1] > array[i] && k > 0)
        {
            top--;
            k--;
        }
        stack[top++] = array[i];
    }
    int offset = 0;
    while (offset < newLength && stack[offset].Equals('0'))
    {
        offset++;
    }
    return (offset == newLength ? "0" : new string(stack, offset, newLength - offset));
}