using static System.Console;

int w = 10;
int[] p = new int[] { 5, 5, 3, 4, 3 };
int[] g = new int[] { 400, 500, 200, 300, 350 };
WriteLine(getBestGold(w, p, g));


int getBestGold(int w, int[] p, int[] g)
{
    int[] result = new int[w + 1];
    for (int i = 1; i <= g.Length; i++)
    {
        for (int j = w; j >= 1; j--)
        {
            if (j >= p[i - 1])
            {
                result[j] = Math.Max(result[j], result[j - p[i - 1]] + g[i - 1]);
            }
        }
    }
    return result[w];
}