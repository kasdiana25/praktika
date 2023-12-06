/* Задание 1
 string[] lines = File.ReadAllLines("input.txt");
string[] lucky = lines[0].Split(' ');
int tiket = Convert.ToInt32(lines[1]);
StreamWriter writer = new StreamWriter("output.txt", true);
for (int i = 2; i < 2 + tiket; i++)
{
    int a = 0;
    string[] Num = lines[i].Split(' ');
    foreach (var n in Num)
    {
        if (lucky.Contains(n))
        {
            a++;
        }
    }

    if (a >= 3)
    {
        writer.WriteLine("Lucky");
        Console.WriteLine("Lucky");
    }
    else
    {   
        writer.WriteLine("Unlucky");
        Console.WriteLine("Unlucky");
    }
}
writer.Close();
 */

/* Задание 2
  string[] num = File.ReadAllLines("nums.txt");
  string[] nums = num[0].Split(' ');
List<string> b = new List<string>();
foreach (var n in nums)
{
    if (Convert.ToInt32(n) % 2 != 0)
    {
        b.Add(n);
    }
}

string number = " ";
foreach (var n in b)
{
    number += $"{n} ";
}

StreamWriter writer = new StreamWriter("nums.txt", false);
writer.Write(number);
writer.Close();

 */


using System.Threading.Channels;

string[] num = File.ReadAllLines("xxx.txt")[0].Split(',');
int[] height = new int[num.Length];
int maxS = 0;
int a = 0;
int b = 0;
for (int i = 0; i < num.Length; i++)
{
    height[i] = Convert.ToInt32(num[i]);
}

for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        int minHeight = 0;
        if (height[i] < height[j])
        {
            minHeight = height[i];
        }
        else
        {
            minHeight = height[j];
        }

        int dist;
        if (i > j)
        {
            dist = i - j;
        }
        else
        {
            dist = j - i;
        }

        int S = dist * minHeight;
        if (maxS < S)
        {
            maxS = S;
            a = i + 1;
            b = j + 1;
        }
    }
}

Console.WriteLine($"{a},{b}");
Console.WriteLine($"{maxS} максимальная площадь");
