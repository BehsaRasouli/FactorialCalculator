using System;

class Program
{
    // این متد فاکتوریل یه عدد رو حساب می‌کنه (بازگشتی)
    static long Factoriel(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factoriel(n - 1);  // خودش رو صدا می‌زنه
    }

    static void Main(string[] args)
    {
        Console.WriteLine("برنامه فاکتوریل ۶ تا عدد");
        Console.WriteLine("===========================");

        // آرایه برای نگه داشتن ۶ تا عدد
        int[] adadha = new int[6];

        // گرفتن ۶ تا عدد از کاربر
        for (int i = 0; i < 6; i++)
        {
            Console.Write("عدد " + (i + 1) + " رو بده: ");
            adadha[i] = int.Parse(Console.ReadLine());

            // اگه منفی یا خیلی بزرگ بود یه هشدار بدم (خودم اضافه کردم)
            if (adadha[i] < 0)
            {
                Console.WriteLine(" منفی؟ فاکتوریل منفی نداریم! صفر می‌ذارم جای اون");
                adadha[i] = 0;
            }
            if (adadha[i] > 20)
            {
                Console.WriteLine(" وای این خیلی بزرگه! عددش از حد میاد بیرون، بازم حساب می‌کنم ولی...");
            }
        }

        Console.WriteLine("\nفاکتوریل عددها اینا شدن:\n");

        // نمایش فاکتوریل هر کدوم
        for (int i = 0; i < 6; i++)
        {
            long natije = Factoriel(adadha[i]);
            Console.WriteLine("فاکتوریل " + adadha[i] + " = " + natije);
        }

        Console.WriteLine("\nتموم شد رفیق! یه دکمه بزن برنامه بسته بشه...");
        Console.ReadKey();
    }
}