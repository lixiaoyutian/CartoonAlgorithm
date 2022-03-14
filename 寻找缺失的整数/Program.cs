using static System.Console;

int[] result = findLostNum(new int[] { 4, 1, 2, 2, 5, 1, 4, 3 });
foreach (var item in result)
{
    Write(item + " ");
}
WriteLine();

int[] findLostNum(int[] array)
{
    int[] result = new int[2];
    int xorResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        xorResult ^= array[i];
    }
    if (xorResult == 0)
    {
        return null;
    }
    int separator = 1;
    while (0 == (xorResult & separator))
    {
        separator <<= 1;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if ((separator & array[i]) == 0)
        {
            result[0] ^= array[i];
        }
        else
        {
            result[1] ^= array[i];
        }
    }
    return result;
}