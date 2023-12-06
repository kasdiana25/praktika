/* Задание 1
 class Program
 {
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask1.txt")[0].Split(' ');
        foreach (var n in words)
        {
            if (n.Length % 2 != 0)
            {
                Console.WriteLine(n);
            }
        }
    }
}
*/

/* Задание 2
class Program
 {
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");
        string a = " "; 
        foreach (var n in words)
        {
            a += n;
            a += " ";
        }
        Console.WriteLine(a);
    }
}
*/

/* Задание 3
 Console.WriteLine("Введите число: ");
 int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0 && a % 10 == 0)
{
    Console.WriteLine($"Число {a} четное и кратно 10");
}
else
{
    Console.WriteLine($"Число {a} не четное и не кратно 10");
}
 */
 
/* Задание 4
 Console.WriteLine("Введите положительные числа (введите отрицательное чтобы остановить ввод): ");
 List<int> nums = new List<int>();
 int num = Convert.ToInt32(Console.ReadLine());
 while (num>0)
 {
     nums.Add(num);
     num = Convert.ToInt32(Console.ReadLine());
 }
 Console.WriteLine("Введите положиетльное число a: ");
 int a = Convert.ToInt32(Console.ReadLine());
 int sum = 0;
 foreach (var n in nums)
 {
     if (n % a == 0)
     {
         sum += n;
     } 
 }
 
Console.WriteLine($"Сумма чисел: {sum}"); 
 */

/* Задание 5
 
 int n = Convert.ToInt32(Console.ReadLine());
 int m = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[n, m];
int[,] b = new int[n, m + 1];
Random rand = new Random();
int c = 0;
for (int i = 0; i < n; i++)
{
    c = 0;
    for (int j = 0; j < m; j++)
    {
        a[i, j] = rand.Next(0, 2);
        b[i, j] = a[i, j];
        if (b[i, j] == 1)
        {
            c++;
        }
    }
    if (c % 2 != 0)
    {
        b[i, m] = 1;
    }
    else
    {
        b[i, m] = 0;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m + 1; j++)
    {
        Console.Write(b[i,j]);
    }

    Console.WriteLine();
}
 */

/* Задание 6
 Random rand = new Random();
 int size = rand.Next(5, 25);
float[] nums = new float[size];
int plus1 = 0; 
int minus1 = 0; 
for (int i = 0; i < size; i++)
{
    nums[i] = rand.NextSingle() * 200 - 100;
    if (nums[i] > 0)
    {
        plus1++;
    }
    if (nums[i] < 0)
    {
        minus1++;
    }
}

float[] plus = new float[plus1];
float[] minus = new float[minus1];
int plusIndex = 0;
int minusIndex = 0;

foreach (var n in nums)
{
    if (n > 0)
    {
        plus[plusIndex] = n;
        plusIndex++;
    }
    else if (n < 0)
    {
        minus[minusIndex] = n;
        minusIndex++;
    }
}

Console.WriteLine("Положительные элементы:");
foreach (var num in plus)
{
    Console.Write(num + " ");
}
Console.WriteLine("\n Отрицательные элементы:");
foreach (var num in minus)
{
    Console.Write(num + " ");
}
 */



