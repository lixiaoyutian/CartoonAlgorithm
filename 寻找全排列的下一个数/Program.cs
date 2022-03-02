using static System.Console;

int[] numbers = new int[] { 1, 2, 3, 4, 5 };
for (int i = 0; i < 10; i++)
{
    numbers = findNearestNumber(numbers);
    for (int j = 0; j < numbers.Length; j++)
    {
        Write(numbers[j]);
    }
    WriteLine();
}



int[] findNearestNumber(int[] numbers)
{
    int index = findTransferPoint(numbers);
    if (index == 0)
    {
        return null;
    }
    int[] numbersCopy = new int[numbers.Length];
    numbers.CopyTo(numbersCopy, 0);
    exchangeHead(numbersCopy, index);
    reverse(numbersCopy, index);
    return numbersCopy;
}

int findTransferPoint(int[] numbers)
{
    for (int i = numbers.Length - 1; i > 0; i--)
    {
        if (numbers[i] > numbers[i - 1])
        {
            return i;
        }
    }
    return 0;
}

void exchangeHead(int[] numbers, int index)
{
    int head = numbers[index - 1];
    for (int i = numbers.Length - 1; i > 0; i--)
    {
        if (numbers[i] > head)
        {
            numbers[index - 1] = numbers[i];
            numbers[i] = head;
            break;
        }
    }
}
void reverse(int[] numbers, int index)
{
    for (int i = index, j = numbers.Length - 1; i < j; i++, j--)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }
}