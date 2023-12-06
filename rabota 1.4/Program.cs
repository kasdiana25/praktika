/* Задание 1
 Console.WriteLine("Введите  целое положительное число n: ");
 int n = Convert.ToInt32(Console.ReadLine());
int a = 1; 
for (int i = 3; i < n; i++)
{
    if (i % 3 == 0)
    {
        a *= i;
    }
}
Console.WriteLine($"Произведение равно {a}");
*/

/* Задание 2
public class Mainc
{
public static void Main()
{
    string[] num = File.ReadAllLines("numsTask2.txt");
    string[] nums = num[0].Split(';');
    float sum = 0;
    foreach (var n in nums)
    {
        if (Convert.ToSingle(n) == 0)
        {
            break;
        }
        if (Convert.ToSingle(n) > 0)
        {
            sum += Convert.ToSingle(n);
        }
    }
    Console.WriteLine($"Сумма положительный чисел: {sum}");
}
}
 */

/* Задание 3
 
 public class Mainc
 {
    public static void Main()
    {
        string[] num = File.ReadAllLines("numsTask3.txt");
        string[] nums = num[0].Split(',');
        int max = -100;
        int min = 100;
        foreach (var n in nums)
        {
            if (Convert.ToInt32(n) == 0)
            {
                break;
            }
            if (Convert.ToInt32(n) > max)
            {
                max = Convert.ToInt32(n);
            }
            if (Convert.ToInt32(n) < min)
            {
                min = Convert.ToInt32(n);
            }
        
        }
        double a = Convert.ToDouble(min) / Convert.ToDouble(max);
        double b = Convert.ToDouble(max) / Convert.ToDouble(min);
        Console.WriteLine($"Отношение минимального к максимальному: {a}");
        Console.WriteLine($"Отношение максимального к минимальному: {b}");
    }
}
 */

/* Задание 4
string[] nums = File.ReadAllLines("numsTask4.txt")[0].Split(' '); 
int numbers = 1; 
int kolvo = 1; 
for (int i = 1; i < nums.Length; i++) 
{ 
    if (nums[i] == nums[i-1]) 
    { 
        numbers++; 
        if (numbers > kolvo) 
        { 
            kolvo = numbers; 
        } 
    } 
    else 
    { 
        numbers = 1; 
    } 
 
} 
Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {kolvo}");
*/

/* Задание 5 
Console.WriteLine("Введите координаты точек a, b: ");
float a = Convert.ToSingle(Console.ReadLine());
float b = Convert.ToSingle(Console.ReadLine());
float x1 = 3;
float x2 = -1;
float y1 = 4;
float y2 = -2;
if ((a >= x2 && a <= x1) && (b >= y2 && b <= y1))
{
    Console.WriteLine($"Точка принадлежит заштрихованной области");
}
else
{
    Console.WriteLine($"Точка не принадлежит заштрихованной области");
}
*/

Console.WriteLine("Введите координаты точек a, b: ");
float a = Convert.ToSingle(Console.ReadLine());
float b = Convert.ToSingle(Console.ReadLine());
float x1 = -2; float x2 = 0; float x3 = 2;
float y1 = -3; float y2 = 2; float y3 = -3;
float d = (x1 - a) * (y2 - y1) - (x2 - x1) * (y1 - b);
float e = (x2 - a) * (y3 - y2) - (x3 - x2) * (y2 - b);
float f = (x3 - a) * (y1 - y3) - (x1 - x3) * (y3 - b);
if ((d >= 0 && e >= 0 && f >= 0) || (d <= 0 && e <= 0 && f <= 0))
{
    Console.WriteLine("Принадлежит треугольнику");
}
else
{
    Console.WriteLine("Не принадлежит треугольнику");
}