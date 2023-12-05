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


string[] num = File.ReadAllLines("xxx.txt")[0].Split(',');;
int max = 0;
foreach (var n in num)
{
    Console.WriteLine(n);
}
for (int i = 0; i < num.Length; i++)
{
    for (int j = i + 1; j < num.Length; j++)
    {
        
    }
}
