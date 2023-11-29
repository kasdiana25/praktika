/* Задание 1
 
 int []array = new int [10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    array [i] = rand.Next(-100, 100);
    Console.Write(array[i] + " ");
}
int minIndex = 0;
int min = array[0];
for (int i = 0; i < 10; i++)
{
    if (min > array[i])
    {
        min = array[i];
        minIndex = i;
    }
} 
Console.WriteLine($"\nиндекс минимального элемента: {minIndex}"); 
*/

/* Задание 2
 
 List<int> nums = new List<int>();
Console.WriteLine("Введите числа (для завершения введите 0)");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int m = 1;

while (num != 0)
{
    nums.Add(num);
    sum += num;
    m *= num;
    
    num = Convert.ToInt32(Console.ReadLine());
} 
int avg = sum / nums.Count;
Console.WriteLine(sum);
Console.WriteLine(m);
Console.WriteLine(avg); 
*/

/* Задание 3
 
 List<string> s = new List<string>(); 
Console.WriteLine("Введите слова (для завершения введите Enter)"); 
string str = Console.ReadLine(); 
string shot = str; 
string lon = str; 
 
while (str != "") 
{ 
    s.Add(str); 
    if (str.Length < shot.Length) 
    { 
        shot = str; 
    } 
    if (str.Length > lon.Length) 
    { 
        lon = str; 
    } 
    str = Console.ReadLine(); 
 
} 
Console.WriteLine($"Самое короткое слово: {shot}"); 
Console.WriteLine($"Самое длинное слово: {lon}"); 
*/

/* Задание 4
 
 namespace ConsoleApp1;

public class Program 
{
    static int[] Filled(int a, int b)
    {
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = rand.Next(a, b);
        }
        return arr;
    }
    
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int[] filledArray = Filled(a, b);
        for (int i = 0; i < filledArray.Length; i++) 
        {
            Console.Write($"{filledArray[i]} ");
        }
    }
}  
*/

/* Задание 5
Console.WriteLine("Введите текст: "); 
string str = Console.ReadLine(); 
int probel = 1; 
foreach (char sym in str) 
{ 
    if (sym == ' ') probel++; 
} 
Console.WriteLine(probel); 
Console.WriteLine($"Start {str} End");
*/




