using static System.Console;

List<int> list = divideRedPackage(1000, 10);
int temp = 0;
foreach (var item in list)
{
    WriteLine(item);
    temp += item;
}
WriteLine(temp);
List<int> divideRedPackage(int totalAmout, int totalPeopleNum)
{
    List<int> amoutList = new List<int>();
    int tempAmout = totalAmout;
    int tempPeople = totalPeopleNum;
    Random random = new Random();
    for (int i = 1; i < totalPeopleNum; i++)
    {
        int amout = random.Next(tempAmout / tempPeople * 2 - 1) + 1;
        tempPeople--;
        tempAmout -= amout;
        amoutList.Add(amout);
    }
    amoutList.Add(tempAmout);
    return amoutList;
}