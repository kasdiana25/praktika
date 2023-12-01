/* Задание 1
 
 namespace ConsoleApp1;
 public class Program 
{
    static void Main()
    {
        List<int> nums = new List<int>(100);
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 100; i++)
        {
            nums.Add(a);
            a -= 3;
        }

        for (int i = 0; i < 100; i++)
        {
            Console.Write($"{nums[i]} ");
        }
    }
}
 */

/* Задание 2
 
 namespace ConsoleApp1;
 public class Program 
{
    static void Main()
    {
        int[] array = new int[100];
        int a = 1;
        for (int i = 0; i < 100; i++)
        {
            array[i] = a;
            a += 2;
        }

        for (int i = 0; i < 100; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}
 */

/* Задание 3
 
 namespace ConsoleApp1;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            array[0, i] = 1;
            array[i, 0] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                array[i, j] = array[i - 1, j] + array[i, j - 1];
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
 */

/* Задание 4
 static double[] AvgTemp(int[,] temps)
 {
    double[] avgMonthTemp = new double[12];
    float sum = 0;

    for (int i = 0; i < 12; i++)
    {
        sum = 0;
        for (int j = 0; j < 30; j++)
        {
            sum = sum + temps[i, j];
        }
        avgMonthTemp[i] = Math.Round(sum / 30, 1);
    }

    return avgMonthTemp;
}

int[,] temperature = new int[12, 30];
int min = -30;
int max = -20;
int x = 8;
Random rand = new Random();

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 30; j++)
    {
        temperature[i, j] = rand.Next(min, max);
    }
   
    if (i<6)
    {
        min = min + x;
        max = max + x;
    }
    else 
    {
        min = min - x;
        max = max - x;
    }
}

double[] avg = AvgTemp(temperature);

Array.Sort(avg);

foreach (var m in avg)
{
    Console.WriteLine(m);
}
 */
 
 /* Задание 5
static Dictionary<string, double> AvgTemp(Dictionary<string, int[]> temps)
  
{
    Dictionary<string, double> avgMonthTemp = new Dictionary<string, double>()
    {
        { "Январь", 0 },
        { "Февраль", 0 },
        { "Март", 0 },
        { "Апрель", 0 },
        { "Май", 0 },
        { "Июнь", 0 },
        { "Июль", 0 },
        { "Август", 0 },
        { "Сентябрь", 0 },
        { "Октябрь", 0 },
        { "Ноябрь", 0 },
        { "Декабрь", 0 }
    };
    float sum = 0;

    int nm = 0;
    foreach (var month in temps)
    {
        sum = 0;
        for (int i = 0; i < 30; i++)
        {
            sum = sum + temps[month.Key][i];
        }
        avgMonthTemp[month.Key] = Math.Round(sum / 30, 1);
        nm++;
    }

    return avgMonthTemp;
}

Dictionary<string, int[]> temperature = new Dictionary<string, int[]>()
{
    {"Январь", new int[30]},
    {"Февраль", new int[30]},
    {"Март", new int[30]},
    {"Апрель", new int[30]},
    {"Май", new int[30]},
    {"Июнь", new int[30]},
    {"Июль", new int[30]},
    {"Август", new int[30]},
    {"Сентябрь", new int[30]},
    {"Октябрь", new int[30]},
    {"Ноябрь", new int[30]},
    {"Декабрь", new int[30]}
};

int min = -30;
int max = -20;
int x = 8;
int nm = 0;
Random rand = new Random();

foreach (var month in temperature)
{
    for (int i = 0; i < 30; i++)
    {
        temperature[month.Key][i] = rand.Next(min, max);
    }
   
    if (nm<6)
    {
        min = min + x;
        max = max + x;
    }
    else 
    {
        min = min - x;
        max = max - x;
    }

    nm++;
}

Dictionary<string, double> avgTemp = AvgTemp(temperature);

foreach (var m in avgTemp)
{
    Console.Write(m.Key + ": ");
    Console.WriteLine(m.Value);
}
  
  
  
 */