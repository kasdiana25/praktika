/* Задание 1
class Program
{
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask1.txt")[0].Split(' ');;
        int[] nums = new int [num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            nums[i] = Convert.ToInt32(num[i]);
        }
        int min = nums[0];
        int minIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                minIndex = i;
            }
        }
        int a = 1;
        for (int i =minIndex + 1; i < nums.Length; i++)
        {
            a *= nums[i];
        }

        Console.WriteLine($"{a}");
    }
}
*/

/* Задание 2
 class Program
 {
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask2.txt")[0].Split(';');;
        float[] nums = new float [num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            nums[i] = Convert.ToSingle(num[i]);
        }
        float temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        StreamWriter writer = new StreamWriter("numsTask2.txt", false);
        string a = "";
        foreach (var n in nums)
        {
            a += $"{n};";

        }
        writer.Write(a);
        writer.Close();
    }
}
 */

/* Задание 3
 class Program
 {
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask3.txt")[0].Split(' ');
        int[] nums = new int [num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            nums[i] = Convert.ToInt32(num[i]);
        }
        int min = nums[0];
        int minIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                minIndex = i;
            }
        }
        int sum = 0;
        int count = 0;
        for (int i = 0; i < minIndex; i++)
        {
            sum += nums[i];
            count++;
        }
        double avg = sum / count;
        Console.WriteLine($"Среднее арифметическое элементов до минимального: {avg}");

    }
}
 */

/* Задание 4
 
 class Program
 {
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask4.txt")[0].Split(' ');
        int[] nums = new int [num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            nums[i] = Convert.ToInt32(num[i]);
        }
        int max = nums[0];
        int maxIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }
        int sum = 0; 
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == max - 1)
            {
                sum += nums[i];
            }
         
        }   
        Console.WriteLine($"{sum}");
    }
}

 */

/* Задание 5
 
 class Program
 {
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask5.txt")[0].Split(' ');
        int[] nums = new int [num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            nums[i] = Convert.ToInt32(num[i]);
        }
         
        int maxIndex = 0;
        int minIndex = 0;
        int sum = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[maxIndex])
            {
                maxIndex = i;
            }

            if (nums[i] < nums[minIndex])
            {
                minIndex = i;
            }
        }

        if (minIndex < maxIndex)
        {
            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                sum += nums[i];
                count++;
            }
        }
        else
        {
            for (int i = maxIndex + 1; i < minIndex; i++)
            {
                sum += nums[i];
                count++;
            }
        }
        double avg = sum / count;
        Console.WriteLine($"Среднее арифметическое элементов между минимальным : {avg}");
         
    } 
}
 */
